using Project_VO;
using Project_VO.HSM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.BaseForm;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.HSM
{
    public partial class Product_Plan : Team5_SmartMOM.BaseGridForm
    {
        public Product_Plan()
        {
            InitializeComponent();
        }

        private void Product_Plan_Load(object sender, EventArgs e)
        {

            dtpDateEnd.Value = DateTime.Now.AddMonths(1);
            InitCombo();
            btnSearch.PerformClick();
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvYellow();
        }

        private void InitCombo() //콥보박스 바인딩
        {
            CommonCodeService service = new CommonCodeService();

            //작업대기 planID
            List<PlanIDVO> listPlanID = service.GetPlanIDByProduction();

            CommonUtil.ComboBinding(cboPlanID, listPlanID, "Plan_ID", "Plan_ID");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            PlanningVO plan = new PlanningVO();
            HSM_Service service = new HSM_Service();

            plan.PlanId = cboPlanID.Text;
            plan.SALES_OrderDate = dtpDateStart.Value.ToShortDateString();
            plan.SALES_DueDate = dtpDateEnd.Value.ToShortDateString();


            DataSet ds = service.GetProductPlan(plan);
            dataGridView1.DataSource = ds.Tables[0];

            dgvSettings();
                   
        }

        private void dgvSettings()
        {            
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 180;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 80;

            dataGridView1.Columns[0].HeaderText = "설비";
            dataGridView1.Columns[1].HeaderText = "공정";
            dataGridView1.Columns[2].HeaderText = "품목";
            dataGridView1.Columns[3].HeaderText = "품명";
            dataGridView1.Columns[4].HeaderText = "규격";
            dataGridView1.Columns[5].HeaderText = "우선순위";

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void dgvYellow()
        {
            for (int i = 6; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (dataGridView1[i, j].Value.ToString() != "0")
                    {
                        dataGridView1[i, j].Style.BackColor = Color.LightYellow;
                    }
                }
            }
        }

        private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateStart.Value > dtpDateEnd.Value.AddDays(1))
            {
                MessageBox.Show("시작일보다 빠를 수 없습니다.");
                dtpDateEnd.Value = dtpDateStart.Value.AddMonths(1);
                return;
            }
        }

        private void dtpDateStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateStart.Value > dtpDateEnd.Value)
            {
                MessageBox.Show("종료일보다 늦을 수 없습니다.");
                dtpDateStart.Value = dtpDateEnd.Value.AddMonths(-1);
                return;
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

                xlWorkSheet.Cells[1, 1] = "설비";
                xlWorkSheet.Cells[1, 2] = "공정";
                xlWorkSheet.Cells[1, 3] = "품목";
                xlWorkSheet.Cells[1, 4] = "품명";
                xlWorkSheet.Cells[1, 5] = "규격";
                xlWorkSheet.Cells[1, 6] = "우선순위";

                for (int k = 7; k < dataGridView1.ColumnCount; k++)
                {
                    xlWorkSheet.Cells[1, k] = dataGridView1.Columns[k].HeaderText.ToString();
                    
                }

                for (i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (j = 0; j < dataGridView1.ColumnCount - 1; j++)
                    {
                        if (dataGridView1[j, i].Value != null)
                            xlWorkSheet.Cells[i + 2, j + 1] = dataGridView1[j, i].Value.ToString();
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

    }
}

