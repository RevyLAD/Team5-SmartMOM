using Project_VO;
using Project_VO.HSM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5_SmartMOM.BaseForm;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.PSM
{
    public partial class Purchasing : BaseGridForm
    {
        List<PlanIDVO> listPlanID;
        public Purchasing()
        {
            InitializeComponent();
        }

        private void Purchasing_Load(object sender, EventArgs e)
        {            
            dtpDateStart.Value = DateTime.Now;
            dtpDateEnd.Value = DateTime.Now.AddMonths(1);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);            
            InitCombo();
            btnSearch_Click(null, new EventArgs());
            dgvSettings();
        }

        public void InitCombo()
        {
            CommonCodeService service = new CommonCodeService();
            listPlanID = service.GetAllPlanID2();

            //콤보박스 콤보바인딩
            CommonUtil.ComboBinding(cboPlanID, listPlanID, "Plan_ID", "Plan_ID");
        }

        //발주 팝업창
        private void button2_Click(object sender, EventArgs e)
        {
            PlanIDVO listPlanID = new PlanIDVO();
            listPlanID.Plan_ID = cboPlanID.Text;

            Purchasing_Order frm = new Purchasing_Order(listPlanID, this);            
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        //데이트타임피커 기준정보
        private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateStart.Value > dtpDateEnd.Value.AddDays(1))
            {
                MessageBox.Show("시작일보다 빠를 수 없습니다.");
                dtpDateEnd.Value = dtpDateStart.Value.AddMonths(1);
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PlanningVO plan = new PlanningVO();
            HSM_Service service = new HSM_Service();

            plan.PlanId = cboPlanID.Text;
            plan.SALES_OrderDate = dtpDateStart.Value.ToShortDateString();
            plan.SALES_DueDate = dtpDateEnd.Value.ToShortDateString();

            DataSet ds = service.GetMRP(plan);
            dataGridView1.DataSource = ds.Tables[0];

            dgvSettings();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {            
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 3; j < dataGridView1.ColumnCount; j++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value) != 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;                        
                    }
                }
            }
        }

        private void cboPlanID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] arrDate = cboPlanID.Text.Split('_');
            if (arrDate[0] == "전체")
            {
                return;
            }
            if (arrDate[0] == "Project")
            {
                return;
            }
            arrDate[0] = arrDate[0].Insert(4, "-");
            arrDate[0] = arrDate[0].Insert(7, "-");
            //20200101
            dtpDateStart.Value = DateTime.Parse(arrDate[0]);
            dtpDateEnd.Value = DateTime.Parse(arrDate[0]).AddMonths(1);
        }

        private void cboPlanID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13))
            {
                btnSearch_Click(null, new EventArgs());
            }
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;

            int i, j;

            saveFileDialog1.Filter = "Excel Files (*.xls)|*.xls";
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add();
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Cells[1, 1] = "품목코드";
                xlWorkSheet.Cells[1, 2] = "품명";
                xlWorkSheet.Cells[1, 3] = "카테고리";
                xlWorkSheet.Cells[1, 4] = "날짜";

                for (i = 0; i < dataGridView1.RowCount -2; i++)
                {
                    for (j = 0; j < dataGridView1.ColumnCount - 1; j++)
                    {
                        if (dataGridView1[j, i].Value != null)
                            xlWorkSheet.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();
                    }
                }

                xlWorkBook.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close(true);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void dgvSettings()
        {
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
         

            dataGridView1.Columns[0].HeaderText = "품목코드";
            dataGridView1.Columns[1].HeaderText = "품명";
            dataGridView1.Columns[2].HeaderText = "카테고리";
           

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
          
        }
    }
}
