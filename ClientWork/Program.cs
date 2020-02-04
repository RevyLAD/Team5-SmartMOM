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
        static int machineID = 1;
        string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

        static void Main(string[] args)
        {
            Random rnd = new Random((int)DateTime.UtcNow.Ticks);
            machineID = rnd.Next(1, 10);

            Console.WriteLine("생산량 전송 프로그램 시작");
            //SetTimer();
            //TcpStart();
            TcpConnection();

            Console.ReadLine();
            //timer1.Stop();
            //timer1.Dispose();
            Console.WriteLine("생산량 전송 프로그램 종료");
        }
        private static void TcpConnection()
        {
            TcpClient tc = new TcpClient("127.0.0.1", 7000);
            NetworkStream stream = tc.GetStream();

            byte[] outbuff = new byte[1024];
            int nbytes = stream.Read(outbuff, 0, outbuff.Length);
            string outMsg = Encoding.ASCII.GetString(outbuff, 0, nbytes);

            stream.Close();
            tc.Close();

            Console.WriteLine($"{nbytes} bytes : {outMsg}");
            Log.WriteInfo($"{nbytes} bytes : {outMsg}");
        }
        private static void TcpStart()
        {
            TcpClient tc = new TcpClient("127.0.0.1", 7000);
            NetworkStream stream = tc.GetStream();

            string msg = "설비준비완료";
            byte[] buff = Encoding.ASCII.GetBytes(msg);

            stream.Write(buff, 0, buff.Length);

            byte[] outbuff = new byte[1024];
            int nbytes = stream.Read(outbuff, 0, outbuff.Length);
            string outMsg = Encoding.ASCII.GetString(outbuff, 0, nbytes);

            stream.Close();
            tc.Close();

            Console.WriteLine($"{nbytes} bytes : {outMsg}");
            Log.WriteInfo($"{nbytes} bytes : {outMsg}");
        }

        private static void SetTimer()
        {
            timer1 = new Timer(3000);
            timer1.Enabled = true;
            timer1.Elapsed += timer1_Elapsed;
            timer1.AutoReset = true;
        }

        private static void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Random rnd = new Random((int)DateTime.UtcNow.Ticks);

            TcpClient tc = new TcpClient("127.0.0.1", 7000);
            NetworkStream stream = tc.GetStream();

            string msg = $"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")} Machine/{machineID}/{rnd.Next(1, 77)}/{rnd.Next(1, 5)}/{rnd.Next(0, 2)}";
            byte[] buff = Encoding.ASCII.GetBytes(msg);

            stream.Write(buff, 0, buff.Length);

            byte[] outbuff = new byte[1024];
            int nbytes = stream.Read(outbuff, 0, outbuff.Length);
            string outMsg = Encoding.ASCII.GetString(outbuff, 0, nbytes);

            stream.Close();
            tc.Close();

            Console.WriteLine($"{nbytes} bytes : {outMsg}");
            Log.WriteInfo($"{nbytes} bytes : {outMsg}");
        }
    }
}
