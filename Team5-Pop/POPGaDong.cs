﻿using System;
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
using System.Net;
using System.Data.SqlClient;

namespace Team5_Pop
{
    public partial class POPGaDong : Form
    {

        static System.Timers.Timer timer1;
        static int machineID = 1;
        static string writeFolder = AppDomain.CurrentDomain.BaseDirectory + "\\Production";
        static int iCnt = 0;
        string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

        PopVO thisvo;
        public POPGaDong(PopVO vo)
        {
            InitializeComponent();

            this.thisvo = vo;
        }
        private void POPGaDong_Load(object sender, EventArgs e)
        {
            DataLoad();

            Random rnd = new Random((int)DateTime.UtcNow.Ticks);
            machineID = rnd.Next(1, 10);

            SetTimer();

            textBox23.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();

            AsyncEchoServer();
        }

        private void DataLoad()
        {
            PopService service = new PopService();

            txtOrderID.Text = thisvo.WO_ID;
            txtDirectQty.Text = txtNoCount.Text = Convert.ToString(thisvo.directQty.ToString("0000"));

            txtFacName.Text = thisvo.FAC_Name;

            string[] FACG = service.GetGaDongInfo(thisvo.FAC_Name);
            txtFACGName.Text = FACG[0] + " / " + FACG[1];
            txtItem.Text = $"{service.GetItemName(thisvo.ITEM_Code)} ({thisvo.ITEM_Code})";

            string[] Time = service.GetPlanTime(thisvo.FAC_Name);


            txtPlanTS.Text = TimeSub(Time[0]);
            txtPlanTE.Text = TimeSub(Time[1]);

            //thisvo.planQty;
            //thisvo.Plan_ID;
            //thisvo.WO_StartDate;
            //thisvo.WO_EndDate;
            //thisvo.WO_Priority;
            //thisvo.WO_State;
            //thisvo.WO_Time;
        }
        async Task AsyncEchoServer()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 7000);
            listener.Start();
            while (true)
            {
                TcpClient tc = await listener.AcceptTcpClientAsync().ConfigureAwait(false);
                await Task.Factory.StartNew(AsyncTcpProcess, tc);
            }
        }

        private async Task AsyncTcpProcess(object o)
        {
            TcpClient tc = (TcpClient)o;
            NetworkStream stream = tc.GetStream();

            string msg =  thisvo.ITEM_Code;
            byte[] buff = Encoding.ASCII.GetBytes(msg);

            stream.Write(buff, 0, buff.Length);

            byte[] buff2 = new byte[1024];
            var readTask = stream.ReadAsync(buff2, 0, buff2.Length);
            int nbytes = readTask.Result;
            if (nbytes > 0)
            {
                //20200204 12:01:20 Machine7/65/4/0
                string[] arrData = Encoding.ASCII.GetString(buff2, 0, nbytes).Split('/');
                //if (arrData.Length == 5)
                //{
                //    using (SqlCommand cmd = new SqlCommand())
                //    {
                //        cmd.Connection = new SqlConnection(strConn);
                //        cmd.CommandText = "insert into WorkQtyLog(ProductID, MachineID, Qty, BadQty) values (@ProductID, @MachineID, @Qty, @BadQty)";

                //        cmd.Parameters.AddWithValue("@ProductID", int.Parse(arrData[2]));
                //        cmd.Parameters.AddWithValue("@MachineID", int.Parse(arrData[1]));
                //        cmd.Parameters.AddWithValue("@Qty", int.Parse(arrData[3]));
                //        cmd.Parameters.AddWithValue("@BadQty", int.Parse(arrData[4]));

                //        cmd.Connection.Open();
                //        cmd.ExecuteNonQuery();
                //        cmd.Connection.Close();
                //    }
                //}

                MessageBox.Show(Encoding.ASCII.GetString(buff2, 0, nbytes));
                listBox1.Items.Insert(0,Encoding.ASCII.GetString(buff2, 0, nbytes));
                //Console.WriteLine(Encoding.ASCII.GetString(buff, 0, nbytes));
                Program.Log.WriteInfo(Encoding.ASCII.GetString(buff2, 0, nbytes));

                await stream.WriteAsync(buff2, 0, nbytes).ConfigureAwait(false);
            }

            stream.Close();
            tc.Close();
        }
        private string TimeSub(string time)
        {
            try
            {
                string temp = string.Empty;
                if (time.Length > 5)
                {
                    temp = time.Substring(0, 2) + ":" + time.Substring(2, 2) + ":" + time.Substring(4, 2);
                }
                else if (time.Length <= 5)
                {
                    temp = "0" + time.Substring(0, 1) + ":" + time.Substring(1, 2) + ":" + time.Substring(3, 2);
                }
                return temp;
            }
            catch
            {
                return null;
            }
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

        private void timer2_Tick(object sender, EventArgs e)
        {

            GaDongTimeChange();
        }

        private void GaDongTimeChange()
        {
            int hour = Convert.ToInt32(txtHour.Text);
            int min = Convert.ToInt32(txtMin.Text);
            int sec = Convert.ToInt32(txtSec.Text);

            if (++sec==60)
            {
                sec = 0;
                if (++min == 60)
                {
                    min = 0;
                    hour++;
                }
            }

            txtHour.Text = Convert.ToString(hour.ToString("00"));
            txtMin.Text = Convert.ToString(min.ToString("00"));
            txtSec.Text = Convert.ToString(sec.ToString("00"));
            textBox22.Text = txtMin.Text + " 분";

            txtCount.Text = Convert.ToString((Convert.ToInt64(txtCount.Text)+1).ToString("0000"));
            txtNoCount.Text = Convert.ToString((Convert.ToInt64(txtDirectQty.Text) - Convert.ToInt64(txtCount.Text)).ToString("0000"));

            if (txtCount.Text.Trim() == txtDirectQty.Text.Trim())
            {
                timer2.Stop();
                progressBar1.Value = 100;
                button6.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                progressBar1.Value = (int)((Convert.ToDouble(txtCount.Text) / Convert.ToDouble(txtDirectQty.Text)) * 100);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "일시 정지")
            {
                timer2.Stop();
                button6.Text = "계속하기";
            }
            else if(button6.Text == "계속하기")
            {
                timer2.Start();
                button6.Text = "일시 정지";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
