using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Team5_Pop
{
    //public delegate void DataGetEventHandler(object sender, PopEventAgrs args);
    public partial class POPGaDong : Form
    {
        //public event DataGetEventHandler DataGethering;

        static int machineID = 1;
        static string writeFolder = AppDomain.CurrentDomain.BaseDirectory + "\\Production";
        static int iCnt = 0;
        string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        string ipAddress = ConfigurationManager.AppSettings["MachineIP"];
        public string checkid;
        PopVO thisvo;
        int thisport;
        bool start;
        int qty;
        string connected = "ㆍㆍㆍ 연결 대기중 ㆍㆍㆍ";
        string endstate;
        PoPMain mainform;

        public POPGaDong(PopVO vo, int newport, PoPMain mainform)
        {
            InitializeComponent();

            this.mainform = mainform;

            this.thisvo = vo;
            this.thisport = newport;
            checkid = thisvo.WO_ID;
            double wotime = thisvo.WO_Time;
            double directqty = thisvo.directQty;

            TickTime = Convert.ToString((wotime/directqty)*1000);
        }
        private void POPGaDong_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            DataLoad();
            
            btnStop.Enabled = false;
            btnSave.Enabled = false;

            SetMTimer();
            Mtimer.Stop();

            Random rnd = new Random((int)DateTime.UtcNow.Ticks);
            machineID = rnd.Next(1, 10);

            textBox23.Text = DateTime.Now.ToLongTimeString();
            start = false;
        }

        private void TcpListenerStart()
        {
            AsyncEchoServer().Wait();
        }

        private void SetMTimer()
        {
            Mtimer = new System.Timers.Timer((int)(Convert.ToDouble(TickTime)));
            Mtimer.Enabled = true;
            Mtimer.Elapsed += Mtimer_Elapsed;
            Mtimer.AutoReset = true;
        }

        public async void Mtimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                //string msg1 = thisvo.ITEM_Code + '/' + txtDirectQty.Text;
                //byte[] buff = Encoding.ASCII.GetBytes(msg1);

                byte[] buff2 = new byte[1024];
                await stream.ReadAsync(buff2, 0, buff2.Length);
                string readmsg = Encoding.ASCII.GetString(buff2);

                timer1.Start();

                if (readmsg != null)
                {
                    qty = Convert.ToInt32(readmsg.Split('/')[5]);

                    //goodqtt = Convert.ToInt32(readmsg.Substring(25, 1));
                    //badqtt = Convert.ToInt32(readmsg.Substring(48, 1));
                }
                
                listBox1.Items.Add(readmsg);
                
                PopService service = new PopService();
                PoPLogVO logvo = new PoPLogVO();

                btnStop.Enabled = true;
                btnStart.Enabled = false;

                if (!start)
                {
                    service.UpdateFacState(thisvo.FAC_Name, thisvo.WO_ID);
                    start = true;
                }
                //tmplist.Add();

                logvo.WO_ID = this.checkid;
                logvo.FAC_Name = txtFacName.Text.Trim();
                logvo.ITEM_Code = thisvo.ITEM_Code;
                logvo.ProductTime = DateTime.Now;

                if (qty == 1)
                {
                    logvo.Qty = "G";
                    txtGoodQty.Text = (Convert.ToInt64(txtGoodQty.Text) +1).ToString("0000");
                }
                else if (qty == 0)
                {
                    logvo.Qty = "B";
                    txtBadQty.Text = (Convert.ToInt64(txtBadQty.Text)+ 1).ToString("0000");
                }
                service.WritePoPLog(logvo);
                
                txtCount.Text = (Convert.ToInt64(txtGoodQty.Text) + Convert.ToInt64(txtBadQty.Text)).ToString("0000");
                GaDongTimeChange();

                //if (DataGethering != null)
                //{
                //    PopEventAgrs args = new PopEventAgrs();
                //    args.good = txtGoodQty.Text;
                //    args.bad = txtBadQty.Text;
                //    args.total = txtCount.Text;
                //    args.newid = thisvo.WO_ID;

                //    DataGethering(this, args);
                //}
            }
            catch
            {
                if (connected.Equals("ㆍㆍㆍ 연결 대기중 ㆍㆍㆍ"))
                    listBox1.Items.Add(connected);
                connected = string.Empty;
            }
        }

        NetworkStream stream;
        string[] FACG;
        private void DataLoad()
        {
            PopService service = new PopService();

            txtOrderID.Text = thisvo.WO_ID;
            txtDirectQty.Text = txtNoCount.Text = Convert.ToString(thisvo.restQty.ToString("0000"));

            txtFacName.Text = thisvo.FAC_Name;

            FACG = service.GetGaDongInfo(thisvo.FAC_Name);
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
        TcpListener listener;
        TcpClient tc;
        async Task AsyncEchoServer()
        {
            listener = new TcpListener(IPAddress.Any, thisport);
            listener.Start();
            while (true)
            {
                tc= await listener.AcceptTcpClientAsync().ConfigureAwait(false);
                await Task.Factory.StartNew(AsyncTcpProcess, tc);
            }
        }
        string TickTime;
        public System.Timers.Timer Mtimer;
        private async Task AsyncTcpProcess(object o)
        {
            TcpClient tc = (TcpClient)o;
            stream = tc.GetStream();
            
            string msg = thisvo.ITEM_Code + '/' + txtDirectQty.Text + '/' + txtNoCount.Text + '/' + TickTime;
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
            Mtimer.Stop();
            Mtimer.Dispose();

            PopService service = new PopService();
            service.UpdateFacStateEnd(thisvo.FAC_Name);
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
                Mtimer.Stop();
                timer1.Stop();
                progressBar1.Value = 100;
                lblprogres.Text = string.Format(progressBar1.Value + " %");

                txtCount.Text = Convert.ToString(Convert.ToInt64(txtGoodQty.Text) + Convert.ToInt64(txtBadQty.Text));

                btnpause.Enabled = false;
                btnStop.Enabled = false;

                string msg = "theend";
                endstate = "작업종료";
                byte[] buff = Encoding.ASCII.GetBytes(msg);
                //stream.Write(buff, 0, buff.Length);
                stream.WriteAsync(buff, 0, buff.Length);

                listBox1.Items.Add("ㆍㆍㆍ 생산 종료 ㆍㆍㆍ");

                btnSave.Enabled = true;
            }
            else
            {
                progressBar1.Value = (int)((Convert.ToDouble(txtCount.Text) / Convert.ToDouble(txtDirectQty.Text)) * 100);
                lblprogres.Text = string.Format(progressBar1.Value +" %");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PopService service = new PopService();

            if (btnpause.Text == "일시 정지")
            {
                listBox1.Items.Add("ㆍㆍㆍ 일시 정지 ㆍㆍㆍ");
                Mtimer.Stop();
                timer1.Stop();
                timer3.Start();
                service.UpdateFacStatePause(thisvo.FAC_Name, 1);
                
                progressBar1.ForeColor = Color.LightYellow;
                btnpause.Text = "계속하기";

                string msg = "pause";
                byte[] buff = Encoding.ASCII.GetBytes(msg);
                //stream.Write(buff, 0, buff.Length);
                stream.WriteAsync(buff, 0, buff.Length);
                
            }
            else if(btnpause.Text == "계속하기")
            {

                listBox1.Items.Add("ㆍㆍㆍ 일시 정지 해제 ㆍㆍㆍ");
                Mtimer.Start();
                timer1.Start();
                timer3.Stop();
                service.UpdateFacStatePause(thisvo.FAC_Name, 2);

                progressBar1.ForeColor = Color.Aquamarine;
                btnpause.Text = "일시 정지";

                string msg = "continue";
                byte[] buff = Encoding.ASCII.GetBytes(msg);
                //stream.Write(buff, 0, buff.Length);
                stream.WriteAsync(buff, 0, buff.Length);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            this.mainform.mainform.DeleteTabPages(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            new Thread(TcpListenerStart).Start();
            Mtimer.Start();
            btnCancel.Enabled = false;
            btnpause.Enabled = true;
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

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnBadInsert.Enabled = false;
            btnSave.Enabled = true;
            btnpause.Enabled = false;

            timer1.Stop();
            Mtimer.Stop();
            timer3.Stop();

            PopService service = new PopService();
            service.UpdateFacStateEnd(thisvo.FAC_Name);

            btnStop.Enabled = false;

            string msg = "stop/"+txtNoCount.Text;
            byte[] buff = Encoding.ASCII.GetBytes(msg);
            stream.WriteAsync(buff, 0, buff.Length);

            endstate = "작업중지";
            listBox1.Items.Add("ㆍㆍㆍ 작업 중지 ㆍㆍㆍ");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("===[생산 실적 정보]===" +
                $"ㆍ생산 번호\t:\t{thisvo.WO_ID}\n" +
                $"ㆍ주문 수량\t:\t{thisvo.directQty}\n" +
                $"ㆍ양품 수량\t:\t{txtGoodQty.Text}\n" +
                $"ㆍ불량 수량\t:\t{txtBadQty.Text}\n" +
                $"ㆍ제작 수량\t:\t{txtCount.Text}\n" +
                $"ㆍ잔여 수량\t:\t{txtNoCount.Text}\n" +
                $"=================\n\n위의 데이터를 저장합니다." +
                "\n화면을 종료하시겠습니까?","실적 저장" ,
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PoPEndVO tempvo = new PoPEndVO();

                tempvo.WO_ID = thisvo.WO_ID;
                tempvo.WO_State= endstate;
                tempvo.GoodQty = Convert.ToInt32(txtGoodQty.Text.Trim());
                tempvo.BadQty = Convert.ToInt32(txtBadQty.Text.Trim());
                tempvo.restQty = Convert.ToInt32(txtNoCount.Text.Trim());
                tempvo.WO_WorkEndTime = DateTime.Now;

                PopService service = new PopService();
                service.SavePopData(tempvo);
                service.UpdateFacStateEnd(thisvo.FAC_Name);

                
                this.mainform.mainform.DeleteTabPages(this);
                this.mainform.DataLoad();

                stream.Close();
                tc.Close();

                this.Close();
            }
            else
            {
                btnSave.Enabled = false;
            }
        }
    }

    //public class PopEventAgrs:EventArgs
    //{
    //    public string total;
    //    public string good;
    //    public string bad;
    //    public string newid;        
    //}
}
