using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Timers;
using log4net.Core;
using System.IO;
using System.Configuration;

namespace Team5_Pop
{
    public partial class POPGaDong : Form
    {

        static System.Timers.Timer timer1;
        static int machineID = 1;
        static string writeFolder = AppDomain.CurrentDomain.BaseDirectory + "\\Production";
        static int iCnt = 0;
        public POPGaDong()
        {
            InitializeComponent();
        }

        private void POPGaDong_Load(object sender, EventArgs e)
        {
            
            Random rnd = new Random((int)DateTime.UtcNow.Ticks);
            machineID = rnd.Next(1, 10);

            Console.WriteLine("생산량 전송 프로그램 시작");
            SetTimer();

            Console.ReadLine();
            Console.WriteLine("생산량 전송 프로그램 종료");
        }

        private static void SetTimer()
        {
            timer1 = new System.Timers.Timer(3000);
            timer1.Enabled = true;
            timer1.Elapsed += timer1_Elapsed;
            timer1.AutoReset = true;
        }

        private static void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Random rnd = new Random((int)DateTime.UtcNow.Ticks);
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter($"{writeFolder}\\WorkerLogMachine_{machineID}_{iCnt}.log", false);

                string msg = $"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")} Machine/{machineID}/{rnd.Next(1, 77)}/{rnd.Next(100, 130)}/{rnd.Next(0, 5)}";
                sw.WriteLine(msg);
                sw.Flush();
                sw.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            finally
            {
                iCnt++;
            }
        }

        private void POPGaDong_FormClosed(object sender, FormClosedEventArgs e)
        {

            timer1.Stop();
            timer1.Dispose();
        }
    }
}
