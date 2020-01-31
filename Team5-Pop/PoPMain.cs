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
        public PoPMain()
        {
            InitializeComponent();
        }

        private void PoPMain_Load(object sender, EventArgs e)
        {
            //현재 시간 상단 출력
            lblNowDate.Text = DateTime.Now.ToLongDateString();
            lblNowTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

            DataLoad();
        }


        List<PopVO> volist;
        int CurrentPage;
        int MaxPage;
        double ContentNum = 6.0;
        private void DataLoad()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.RowTemplate.Height = 48;

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "번호", "WO_ID", true, 249);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목 코드", "ITEM_Code", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비명", "FAC_Name", false, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시작일", "WO_StartDate", false, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "종료일", "WO_EndDate", false, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "계획수량", "planQty", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "지시수량", "directQty", false, 60);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "작업지시상태", "WO_State", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "계획번호", "Plan_ID", false, 102);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "우선순위", "WO_Priority", false, 40);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소요시간(분)", "WO_Time", false, 60);

            this.dataGridView1.Font = new Font("맑은고딕", 16, FontStyle.Regular);
            this.dataGridView1.ColumnHeadersHeight = 100;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Columns[0].Resizable = DataGridViewTriState.False;


            PopService service = new PopService();
            volist = service.PopGetData();

            CurrentPage = 1;

            double divPage = volist.Count / ContentNum;
            if (divPage == (int)divPage)
                MaxPage = (int)divPage;
            else
                MaxPage = (int)divPage + 1;

            PagePaging();
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

        private void PagePaging()
        {
            List<PopVO> templist = new List<PopVO>();

            for(int i = (CurrentPage - 1) * (int)ContentNum; i < CurrentPage * ContentNum; i++)
            {
                if (i == volist.Count)
                    break;
                templist.Add(volist[i]);
            }
            btnPageText.Text = string.Format(CurrentPage + " / " + MaxPage);
            dataGridView1.DataSource = templist;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNowDate.Text = DateTime.Now.ToLongDateString();
            lblNowTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
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
                PagePaging();
            }
        }

        private void btnBeforePage_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                PagePaging();
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (CurrentPage != 1)
            {
                CurrentPage = 1;
                PagePaging();
            }
        }

        private void btnEndPage_Click(object sender, EventArgs e)
        {
            if (CurrentPage != MaxPage)
            {
                CurrentPage = MaxPage;
                PagePaging();
            }
        }
    }
}
