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
using System.Threading;

namespace Team5_Pop
{
    public partial class POPGaDong : Form
    {

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

            textBox23.Text = DateTime.Now.ToLongTimeString();
        }

        private void TcpListenerStart()
        {
            AsyncEchoServer().Wait();
        }

        NetworkStream stream;
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
        int goodqtt;
        int badqtt;
        private async Task AsyncTcpProcess(object o)
        {
            TcpClient tc = (TcpClient)o;
            stream = tc.GetStream();

            string msg =  thisvo.ITEM_Code+'/'+ txtDirectQty.Text;
            byte[] buff = Encoding.ASCII.GetBytes(msg);

            stream.Write(buff, 0, buff.Length);


            //var readTask = stream.Read(buff2, 0, buff2.Length);
            //int nbytes = readTask.Result;
            //if (nbytes > 0)
            //{
            //    //20200204 12:01:20 Machine7/65/4/0
            //    string[] arrData = Encoding.ASCII.GetString(buff2, 0, nbytes).Split('/');


            //    //MessageBox.Show(Encoding.ASCII.GetString(buff2, 0, nbytes));
            //   
            //    //Console.WriteLine(Encoding.ASCII.GetString(buff, 0, nbytes));


            //    await stream.WriteAsync(buff2, 0, nbytes).ConfigureAwait(false);
            //}

          //  stream.Close();
          //  tc.Close();
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



        private void POPGaDong_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer2.Stop();
            timer2.Dispose();
        }

        string connected = "ㆍㆍㆍ 연결 대기중 ㆍㆍㆍ";
        private async void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                //string msg1 = thisvo.ITEM_Code + '/' + txtDirectQty.Text;
                //byte[] buff = Encoding.ASCII.GetBytes(msg1);

                byte[] buff2 = new byte[1024];
                await stream.ReadAsync(buff2, 0, buff2.Length);
                string readmsg = Encoding.ASCII.GetString(buff2);

                timer1.Start();
                connected = "ㆍㆍㆍ 연결 대기중 ㆍㆍㆍ";

                if (readmsg != null)
                {
                    goodqtt = Convert.ToInt32(readmsg.Substring(32, 1));
                    badqtt = Convert.ToInt32(readmsg.Substring(48, 1));
                }

                listBox1.Items.Add(readmsg);

                txtCount.Text = Convert.ToString((Convert.ToInt64(txtCount.Text) + (goodqtt+badqtt)).ToString("0000"));
                txtGoodQty.Text = Convert.ToString((Convert.ToInt64(txtGoodQty.Text) + goodqtt).ToString("0000"));
                txtBadQty.Text = Convert.ToString((Convert.ToInt64(txtBadQty.Text) + (badqtt)).ToString("0000"));
                GaDongTimeChange();

                //if (stream != null)
                //    stream.Write(buff, 0, buff.Length);

                Random rnd = new Random((int)DateTime.UtcNow.Ticks);
                StreamWriter sw = null;
                try
                {
                    sw = new StreamWriter($"{writeFolder}\\WorkerLogMachine_{machineID}_{iCnt}.log", false);

                    string msg = $"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")} Machine/{machineID}/{rnd.Next(1, 77)}/{rnd.Next(100, 130)}/{rnd.Next(0, 5)}";
                    listBox1.Items.Add(msg);
                    Program.Log.WriteInfo(msg);

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
            catch
            {
                if(connected.Equals("ㆍㆍㆍ 연결 대기중 ㆍㆍㆍ"))
                    listBox1.Items.Add(connected);
                connected = string.Empty;
            }
        }
        private void GaDongTimeChange()
        {
            txtNoCount.Text = Convert.ToString((Convert.ToInt64(txtDirectQty.Text) - Convert.ToInt64(txtGoodQty.Text)).ToString("0000"));

            if (Convert.ToInt64(txtGoodQty.Text) > Convert.ToInt64(txtDirectQty.Text))
            {
                txtGoodQty.Text = txtDirectQty.Text;
                txtNoCount.Text = "0";
            }

            if (txtDirectQty.Text.Trim() == txtGoodQty.Text.Trim())
            {
                timer2.Stop();
                timer1.Stop();
                progressBar1.Value = 100;
                button6.Enabled = false;
                button3.Enabled = false;

                string msg = "theend";
                byte[] buff = Encoding.ASCII.GetBytes(msg);
                //stream.Write(buff, 0, buff.Length);
                stream.WriteAsync(buff, 0, buff.Length);

                listBox1.Items.Add("ㆍㆍㆍ 생산 종료 ㆍㆍㆍ");
            }
            else
            {
                progressBar1.Value = (int)((Convert.ToDouble(txtCount.Text) / Convert.ToDouble(txtDirectQty.Text)) * 100);
                lblprogres.Text = string.Format(progressBar1.Value +" %");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "일시 정지")
            {
                listBox1.Items.Add("ㆍㆍㆍ 일시 정지 ㆍㆍㆍ");
                timer2.Stop();
                timer1.Stop();
                timer3.Start();
                progressBar1.ForeColor = Color.LightYellow;
                button6.Text = "계속하기";

                string msg = "pause";
                byte[] buff = Encoding.ASCII.GetBytes(msg);
                //stream.Write(buff, 0, buff.Length);
                stream.WriteAsync(buff, 0, buff.Length);
                
            }
            else if(button6.Text == "계속하기")
            {

                listBox1.Items.Add("ㆍㆍㆍ 일시 정지 해제 ㆍㆍㆍ");
                timer2.Start();
                timer1.Start();
                timer3.Stop();
                progressBar1.ForeColor = Color.Aquamarine;
                button6.Text = "일시 정지";

                string msg = "continue";
                byte[] buff = Encoding.ASCII.GetBytes(msg);
                //stream.Write(buff, 0, buff.Length);
                stream.WriteAsync(buff, 0, buff.Length);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            new Thread(TcpListenerStart).Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hour = Convert.ToInt32(txtHour.Text);
            int min = Convert.ToInt32(txtMin.Text);
            int sec = Convert.ToInt32(txtSec.Text);

            if (++sec == 60)
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
        }
        int resttime = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            textBox22.Text = Convert.ToString(++resttime / 60);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
