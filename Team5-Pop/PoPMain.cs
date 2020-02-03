﻿using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5_SmartMOM;

namespace Team5_Pop
{
    public partial class PoPMain : Form
    {
        public PoPMain(MainPoPForm frm)
        {
            InitializeComponent();
            mainform = frm;
        }
        MainPoPForm mainform;
        PopService service;
        List<FacVOp> fac_cbolist;
        private void PoPMain_Load(object sender, EventArgs e)
        {
            service = new PopService();
            //현재 시간 상단 출력
            lblNowDate.Text = DateTime.Now.ToLongDateString();
            lblNowTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

            DataLoad();
            ComboLoad();
            
        }
        private void ComboLoad()
        {
            CommonUtil.ComboBinding(comboBox1, service.GetFACGName(), "FACG_Code", "FACG_Name", "전체");
            fac_cbolist = service.GetFACName();
            CommonUtil.ComboBinding(comboBox2, fac_cbolist, "FAC_Code", "FAC_Name", "전체");
        }

        List<PopVO> volist;
        List<PopVO> nowlist;
        int CurrentPage;
        int MaxPage;
        double ContentNum = 6.0;
        private void DataLoad()
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

            this.dataGridView1.Font = new Font("맑은고딕", 16, FontStyle.Regular);
            this.dataGridView1.ColumnHeadersHeight = 100;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Columns[0].Resizable = DataGridViewTriState.False;

            gadong_vo = new PopVO();
            PopService service = new PopService();
            volist = service.PopGetData();
            CurrentPage = 1;
            nowlist = PagePaging(volist);

            dataGridView1_CellClick(new object(), new DataGridViewCellEventArgs(0, 0));
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StringFormat drawFormat = new StringFormat();

            //drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            using (Brush brush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString(Convert.ToString(Convert.ToInt32(((CurrentPage-1)*ContentNum)) + Convert.ToInt32((e.RowIndex + 1).ToString())), e.InheritedRowStyle.Font,
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
                txtProductNum.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                this.e_temp = e;
            }
            catch
            {

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

        private void button9_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PoPFACG frm = new PoPFACG();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            PoPFAC frm = new PoPFAC();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
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

            dataGridView1_CellClick(new object(), new DataGridViewCellEventArgs(0,0));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = null;
            try
            {
                List<FacVOp> temp = new List<FacVOp>();
                foreach (FacVOp item in fac_cbolist)
                {
                    if(item.FACG_Code == comboBox1.SelectedValue.ToString())
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >0) 
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
                gadong_vo.WO_Time = Convert.ToInt32(dataGridView1.Rows[e_temp.RowIndex].Cells[9].Value.ToString());

                if (service.GetFacState(gadong_vo.FAC_Name) == "비가동")
                {
                    //mainform.CreateTabPages("공정1", new POPGaDong(gadong_vo)); <-- Gadong 폼 생성자에 PoPVO 추가해서 넘겨받아야함 (충돌땜에 내가 못했음)
                    service.UpdateFacState(gadong_vo.FAC_Name, gadong_vo.WO_ID);
                    mainform.CreateTabPages(gadong_vo.FAC_Name, new POPGaDong());

                    DataLoad();

                }
                else
                {
                    MessageBox.Show("이미 공정이 실행중입니다.");
                }
            }
            else
            {
                MessageBox.Show("선택된 작업이 없습니다");
            }
        }
    }
}
