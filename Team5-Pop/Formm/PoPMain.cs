﻿using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5_SmartMOM;

namespace Team5_Pop
{
    public partial class PoPMain : Form
    {
        List<PopVO> volist;
        List<PopVO> nowlist;
        int CurrentPage;
        int MaxPage;

        public MainPoPForm mainform;
        PopService service;
        List<FacVOp> fac_cbolist;

        //한 페이지에 보여줄 작업 수 ↓
        double ContentNum = 5.0;

        string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

        public PoPMain(MainPoPForm frm)
        {
            InitializeComponent();
            mainform = frm;

        }
        private void PoPMain_Load(object sender, EventArgs e)
        {
            service = new PopService();
            portCheck = new List<PortCheck>();
            //현재 시간 상단 출력
            lblNowDate.Text = DateTime.Now.ToLongDateString();
            lblNowTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();



            DataLoad();
            ComboLoad();
        }

        //비동기 서버 시작
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

        private async void AsyncTcpProcess(object o)
        {
            TcpClient tc = (TcpClient)o;
            NetworkStream stream = tc.GetStream();

            string msg = "Machine1 Connect";
            byte[] buff = Encoding.ASCII.GetBytes(msg);

            stream.Write(buff, 0, buff.Length);

            //byte[] buff = new byte[1024];
            var readTask = stream.ReadAsync(buff, 0, buff.Length);
            int nbytes = readTask.Result;
            if (nbytes > 0)
            {
                ////20200204 12:01:20 Machine7/65/4/0
                //string[] arrData = Encoding.ASCII.GetString(buff, 0, nbytes).Split('/');
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

                MessageBox.Show(Encoding.ASCII.GetString(buff, 0, nbytes));
                //Console.WriteLine(Encoding.ASCII.GetString(buff, 0, nbytes));
                Program.Log.WriteInfo(Encoding.ASCII.GetString(buff, 0, nbytes));

                await stream.WriteAsync(buff, 0, nbytes).ConfigureAwait(false);
            }

            stream.Close();
            tc.Close();
        }

        private void ComboLoad()
        {
            CommonUtil.ComboBinding(comboBox1, service.GetFACGName(), "FACG_Code", "FACG_Name", "전체");
            fac_cbolist = service.GetFACName();
            CommonUtil.ComboBinding(comboBox2, fac_cbolist, "FAC_Code", "FAC_Name", "전체");
        }
        List<ingdata> inglist;

        public void DataLoad()
        {

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.RowTemplate.Height = 48;

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "번호", "WO_ID", true, 296);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목 코드", "ITEM_Code", true, 250);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비명", "FAC_Name", false, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시작일", "WO_StartDate", false, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "종료일", "WO_EndDate", false, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "계획수량", "planQty", true, 250);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "지시수량", "directQty", false, 60);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "작업지시상태", "WO_State", true, 250);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "계획번호", "Plan_ID", false, 102);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "우선순위", "WO_Priority", false, 40);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소요시간(분)", "WO_Time", false, 60);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "양품수량", "WO_GoodQty", false, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "불량수량", "WO_BadQty", false, 60);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "잔량", "restQty", false, 60);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "종료시간", "WO_WorkEndTime", false, 60);

            this.dataGridView1.Font = new Font("맑은고딕", 16, FontStyle.Regular);
            this.dataGridView1.ColumnHeadersHeight = 100;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Columns[0].Resizable = DataGridViewTriState.False;

            gadong_vo = new PopVO();
            PopService service = new PopService();
            volist = service.PopGetData();

            inglist = new List<ingdata>();

            foreach (var item in volist)
            {
                inglist.Add(new ingdata(item.WO_ID));
            }
            CurrentPage = 1;
            nowlist = PagePaging(volist);

            dataGridView1_CellClick(new object(), new DataGridViewCellEventArgs(0, 0));
        }

        #region 페이징
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StringFormat drawFormat = new StringFormat();

            //drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            using (Brush brush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString(Convert.ToString(Convert.ToInt32(((CurrentPage - 1) * ContentNum)) + Convert.ToInt32((e.RowIndex + 1).ToString())), e.InheritedRowStyle.Font,
                brush, e.RowBounds.Location.X + 35, e.RowBounds.Location.Y + 4, drawFormat);
            }
        }

        private List<PopVO> PagePaging(List<PopVO> methodlist)
        {
            List<PopVO> templist = new List<PopVO>();

            double divPage = methodlist.Count / ContentNum;
            if (divPage == (int)divPage)
                MaxPage = (int)divPage;
            else
                MaxPage = (int)divPage + 1;

            for (int i = (CurrentPage - 1) * (int)ContentNum; i < CurrentPage * ContentNum; i++)
            {
                if (i == methodlist.Count)
                    break;
                templist.Add(methodlist[i]);
            }
            btnPageText.Text = string.Format(CurrentPage + " / " + MaxPage);
            dataGridView1.DataSource = templist;

            return methodlist;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNowDate.Text = DateTime.Now.ToLongDateString();
            lblNowTime.Text = DateTime.Now.ToLongTimeString();

            //if(inglist != null)
            //{
            //     foreach(var item in inglist)
            //    {
            //        if (item.woid != "")
            //        {
            //            if (item.woid.Equals(textBox3.Text))
            //            {
            //                txtSNum.Text = Convert.ToString(item.totalqty);
            //                txtGoodNum.Text = Convert.ToString(item.goodqty);
            //                txtBadNum.Text = Convert.ToString(item.badqty);
            //                txtProductNum.Text = Convert.ToString(Convert.ToInt32(txtOrderNum.Text) - item.goodqty);
            //            }
            //        }
            //    }
            //}
        }
        PopVO gadong_vo;
        DataGridViewCellEventArgs e_temp;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                txtOrderNum.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtGoodNum.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtBadNum.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                txtProductNum.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                txtSNum.Text = (Convert.ToInt32(txtGoodNum.Text) + Convert.ToInt32(txtBadNum.Text)).ToString();
                this.e_temp = e;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (CurrentPage < MaxPage)
            {
                CurrentPage++;
                PagePaging(nowlist);
            }
        }

        private void btnBeforePage_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                PagePaging(nowlist);
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (CurrentPage != 1)
            {
                CurrentPage = 1;
                PagePaging(nowlist);
            }
        }

        private void btnEndPage_Click(object sender, EventArgs e)
        {
            if (CurrentPage != MaxPage)
            {
                CurrentPage = MaxPage;
                PagePaging(nowlist);
            }
        }

        #endregion

        private void button9_Click(object sender, EventArgs e) //당일버튼
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button10_Click(object sender, EventArgs e) //검색버튼
        {
            List<PopVO> temp = new List<PopVO>();
            CurrentPage = 1;

            if (comboBox2.Text != "전체")
            {
                foreach (PopVO item in volist)
                {
                    if (item.FAC_Name == comboBox2.Text.Trim() &&
                        item.WO_StartDate > dateTimePicker1.Value &&
                        item.WO_EndDate < dateTimePicker2.Value)
                    {
                        temp.Add(item);
                    }
                }
                nowlist = PagePaging(temp);
            }
            else
            {
                foreach (PopVO item in volist)
                {
                    if (item.WO_StartDate > dateTimePicker1.Value &&
                        item.WO_EndDate < dateTimePicker2.Value)
                    {
                        temp.Add(item);
                    }
                }
                nowlist = PagePaging(temp);
            }

            dataGridView1_CellClick(new object(), new DataGridViewCellEventArgs(0, 0));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = null;
            try
            {
                List<FacVOp> temp = new List<FacVOp>();
                foreach (FacVOp item in fac_cbolist)
                {
                    if (item.FACG_Code == comboBox1.SelectedValue.ToString())
                    {
                        temp.Add(item);
                    }
                }

                CommonUtil.ComboBinding(comboBox2, temp, "FAC_Code", "FAC_Name");
                //comboBox2.Text = 
            }
            catch
            {
                CommonUtil.ComboBinding(comboBox2, fac_cbolist, "FAC_Code", "FAC_Name");
            }
        }
        int port;
        List<PortCheck> portCheck;
        private void btnStart_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                gadong_vo.WO_ID = dataGridView1.Rows[e_temp.RowIndex].Cells[0].Value.ToString();
                gadong_vo.ITEM_Code = dataGridView1.Rows[e_temp.RowIndex].Cells[1].Value.ToString();
                gadong_vo.FAC_Name = dataGridView1.Rows[e_temp.RowIndex].Cells[2].Value.ToString();
                gadong_vo.WO_StartDate = Convert.ToDateTime(dataGridView1.Rows[e_temp.RowIndex].Cells[3].Value.ToString());
                gadong_vo.WO_EndDate = Convert.ToDateTime(dataGridView1.Rows[e_temp.RowIndex].Cells[4].Value.ToString());
                gadong_vo.planQty = Convert.ToInt32(dataGridView1.Rows[e_temp.RowIndex].Cells[5].Value.ToString());
                gadong_vo.directQty = Convert.ToInt32(dataGridView1.Rows[e_temp.RowIndex].Cells[6].Value.ToString());
                gadong_vo.WO_State = dataGridView1.Rows[e_temp.RowIndex].Cells[7].Value.ToString();
                gadong_vo.Plan_ID = dataGridView1.Rows[e_temp.RowIndex].Cells[8].Value.ToString();
                gadong_vo.WO_Priority = Convert.ToInt32(dataGridView1.Rows[e_temp.RowIndex].Cells[9].Value.ToString());
                gadong_vo.WO_Time = Convert.ToInt32(dataGridView1.Rows[e_temp.RowIndex].Cells[10].Value.ToString());
                gadong_vo.restQty = Convert.ToInt32(dataGridView1.Rows[e_temp.RowIndex].Cells[14].Value.ToString());
                gadong_vo.WO_GoodQty = Convert.ToInt32(dataGridView1.Rows[e_temp.RowIndex].Cells[11].Value.ToString());
                gadong_vo.WO_BadQty = Convert.ToInt32(dataGridView1.Rows[e_temp.RowIndex].Cells[12].Value.ToString());
                PopService service = new PopService();

                if (service.GetFacState(gadong_vo.FAC_Name) == "가동")
                {
                    MessageBox.Show("이미 공정이 실행중입니다.");
                }
                else
                {
                    if (gadong_vo.WO_State.Trim() == "작업완료")
                    {
                        MessageBox.Show("이미 완료된 작업입니다");
                    }
                    else if (gadong_vo.WO_State.Trim() == "작업시작")
                    {
                        MessageBox.Show("이미 작업이 시작되었습니다");
                    }
                    else
                    {
                        bool umu = false;
                        port = 0;
                        foreach (PortCheck item in portCheck)
                        {
                            if (item.Fac_Name.Equals(gadong_vo.FAC_Name))
                            {
                                item.port = item.port + 1;
                                umu = true;
                                port = item.port;
                                break;
                            }
                        }

                        if (!umu)
                        {
                            port = service.GetPortNum(gadong_vo.WO_ID);
                            PortCheck tempcheck = new PortCheck(gadong_vo.FAC_Name, port);
                            portCheck.Add(tempcheck);
                        }

                        POPGaDong newgadong = new POPGaDong(gadong_vo, port, this);
                        mainform.CreateTabPages(gadong_vo.FAC_Name, newgadong);
                    }
                }

                //newgadong.DataGethering += new DataGetEventHandler(this.DataGet);
                //newgadong.Mtimer.Elapsed += new System.Timers.ElapsedEventHandler(DataUpdate(null, nullargs, gadong_vo));
            }
            else
            {
                MessageBox.Show("선택된 작업이 없습니다");
            }

        }

        //private void DataGet(object sender, PopEventAgrs e)
        //{
        //    //POPGaDong pop = (POPGaDong)sender;
        //    //Debug.WriteLine(pop.checkid);
        //    foreach (var item in inglist)
        //    {
        //        if (item.woid.Equals(e.newid))
        //        {
        //            item.totalqty = Convert.ToInt32(e.total.Trim());
        //            item.goodqty = Convert.ToInt32(e.good.Trim());
        //            item.badqty = Convert.ToInt32(e.bad.Trim());

        //            break;
        //        }
        //    }
        //}

        public class ingdata
        {
            public string woid;
            public int goodqty;
            public int badqty;
            public int totalqty;

            public ingdata(string newWOid)
            {
                woid = newWOid;
                goodqty = 0;
                badqty = 0;
                totalqty = 0;
            }
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            BarcodeForm frm = new BarcodeForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string woId = frm.WorkOrderID.ToString();
                    PopService service = new PopService();
                    gadong_vo = service.GetPoPVOByWoId(woId)[0];

                    if (service.GetFacState(gadong_vo.FAC_Name) == "가동")
                    {
                        MessageBox.Show("이미 공정이 실행중입니다.");
                    }
                    else
                    {
                        if (gadong_vo.WO_State.Trim() == "작업완료")
                        {
                            MessageBox.Show("이미 완료된 작업입니다");
                        }
                        else if (gadong_vo.WO_State.Trim() == "작업시작")
                        {
                            MessageBox.Show("이미 작업이 시작되었습니다");
                        }
                        else
                        {
                            bool umu = false;
                            port = 0;

                            foreach (PortCheck item in portCheck)
                            {
                                if (item.Fac_Name.Equals(gadong_vo.FAC_Name))
                                {
                                    item.port = item.port + 1;
                                    umu = true;
                                    port = item.port;
                                    break;
                                }
                            }

                            if (!umu)
                            {
                                port = service.GetPortNum(gadong_vo.WO_ID);
                                PortCheck tempcheck = new PortCheck(gadong_vo.FAC_Name, port);
                                portCheck.Add(tempcheck);
                            }

                            POPGaDong newgadong = new POPGaDong(gadong_vo, port, this);
                            mainform.CreateTabPages(gadong_vo.FAC_Name, newgadong);
                        }
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnProductLabel_Click(object sender, EventArgs e)
        {
            CreateBarcode();
        }


        private void CreateBarcode() //바코드생성
        {
            DataTable dt = new DataTable();
            dt = setDataTable(dataGridView1, Convert.ToInt32(dataGridView1.CurrentRow.Cells[11].Value)); // 원하는 항목을 데이터테이블로 변환

            ProductLabel rpt = new ProductLabel();
            rpt.DataSource = dt;
            rpt.CreateDocument();


            ShowBarcode frm = new ShowBarcode(rpt);


            //frm.ShowDialog();
        }

        private DataTable setDataTable(DataGridView dgv, int Qty)
        {

            DataTable dt = new DataTable(); // 담을 객체


            dt.Columns.Add("WO_ID", dgv.Columns[0].ValueType);
            dt.Columns.Add("ITEM_Code", dgv.Columns[1].ValueType);
            dt.Columns.Add("WO_GoodQty", dgv.Columns[11].ValueType);
            dt.Columns.Add("WO_WorkEndTime", dgv.Columns[3].ValueType);
            //컬럼 생성
            // 0,1,3,4,5,7
            int tot = 30;
            int count = Qty / 30;

            if (Qty < tot)
                count = 1;

            else if (Qty % tot != 0)
                count = count + 1;


            for (int i = 0; i < count; i++)
            {
                DataRow dr = dt.NewRow();

                if (Qty < tot)
                {
                    dr[0] = dgv[0, e_temp.RowIndex].Value;
                    dr[1] = dgv[1, e_temp.RowIndex].Value;
                    dr[2] = Qty;
                    dr[3] = DateTime.Now;
                }
                else
                {
                    dr[0] = dgv[0, e_temp.RowIndex].Value;
                    dr[1] = dgv[1, e_temp.RowIndex].Value;
                    dr[2] = tot;
                    dr[3] = DateTime.Now;

                    Qty = Qty - tot;
                }

                dt.Rows.Add(dr);

            } //데이터 삽입
            dt.AcceptChanges();
            return dt;
        }
    }
}
