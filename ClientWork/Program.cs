using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Timers;
using log4net.Core;
using WorkerService;
using System.Configuration;

namespace ClientWork
{
    class Program
    {
        private static LoggingUtility _loggingUtility = LoggingUtility.GetLoggingUtility("WorkerClient", Level.Info, 30);
        internal static LoggingUtility Log { get { return _loggingUtility; } }

        static Timer timer1;
        static Timer timer2;
        static int machineID = 1;
        string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

        static void Main(string[] args)
        {
            Random rnd = new Random((int)DateTime.UtcNow.Ticks);
            machineID = rnd.Next(1, 10);

            
            
            SetTimer();
            timer1.Stop();


            while (true)
            {
                Console.WriteLine("If you want to start system, Press Any Key");
                Console.ReadLine();

                if (TcpConnection())
                {
                    Console.WriteLine("연결 확인");
                    break;
                }
                else
                {
                    Console.WriteLine("연결이 확인되지 않았습니다");
                    Console.WriteLine("서버 오픈 확인 후 다시 시도하십시오");
                    Console.ReadLine();
                }
            }
            SetTimer2();
            

            Console.WriteLine("\n\n생산량 전송 프로그램 시작");
            
            timer2.Start();
            timer1.Start();

            Console.ReadLine();

            timer1.Dispose();
            Console.WriteLine("생산량 전송 프로그램 종료");
            Console.ReadLine();
        }

        static TcpClient tc;
        static NetworkStream stream;
        static string product;
        private static bool TcpConnection()
        {
            try
            {
                tc = new TcpClient("127.0.0.1", 7000);
                stream = tc.GetStream();

                byte[] outbuff = new byte[1024];
                int nbytes = stream.Read(outbuff, 0, outbuff.Length);
                string outMsg = Encoding.ASCII.GetString(outbuff, 0, nbytes);

                product = outMsg;
                Console.WriteLine($"product : {product}");
                Log.WriteInfo($"product : {product}");

                return true;
            }
            catch
            {
                return false;
            }
        }
        
        private static void SetTimer()
        {
            timer1 = new Timer(3000);
            timer1.Enabled = true;
            timer1.Elapsed += timer1_Elapsed;
            timer1.AutoReset = true;
        }

        private static void SetTimer2()
        {
            timer2 = new Timer(500);
            timer2.Enabled = true;
            timer2.Elapsed += timer2_Elapsed;
            timer2.AutoReset = true;
        }

        private static void timer2_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                byte[] outbuff = new byte[1024];
                int nbytes = stream.Read(outbuff, 0, outbuff.Length);
                string outMsg = string.Empty;
                outMsg = Encoding.ASCII.GetString(outbuff, 0, nbytes);

                if (outMsg.Equals("pause"))
                {
                    Console.WriteLine("ㆍㆍㆍㆍㆍ일시 정지ㆍㆍㆍㆍ");
                    Log.WriteInfo($"{DateTime.Now.ToLongTimeString()} : {product}  :   === 일시 정지 === ");
                    timer1.Stop();
                }
                else if (outMsg.Equals("continue"))
                {
                    Console.WriteLine("ㆍㆍㆍ일시 정지 해제ㆍㆍㆍ");
                    Log.WriteInfo($"{DateTime.Now.ToLongTimeString()} : {product}  :   == 일시 정지 해제 == ");
                    timer1.Start();
                }
                else if (outMsg.Equals("theend"))
                {
                    Console.WriteLine("ㆍㆍㆍ생산 종료ㆍㆍㆍ");
                    Log.WriteInfo($"{DateTime.Now.ToLongTimeString()} : {product}  :   == 생산 종료 == ");
                    timer2.Stop();
                    timer1.Stop();
                }
            }
            catch(Exception err)
            {
                //Console.WriteLine(err.Message);
            }
        }

        private static void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                Random rnd = new Random((int)DateTime.UtcNow.Ticks);

                int qttamount = rnd.Next(2, 5);
                int badamount = 0;
                if (rnd.Next(1, 80)>75)
                {
                    badamount = 1;
                }

                string msg = $"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")} :: Good Qty :[{qttamount}] , Bad Qty : [{badamount}]";
                byte[] buff = Encoding.ASCII.GetBytes(msg);
                stream.Write(buff, 0, buff.Length);

                Console.WriteLine($"bytes : {msg}");
                Log.WriteInfo($"bytes : {msg}");
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
