using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.PSM
{
    public partial class Import_Check_state : Form
    {
        List<ImportCheckVO> list = new List<ImportCheckVO>();
        CheckBox headerCheckBox = new CheckBox();
        public Import_Check_state()
        {
            InitializeComponent();
        }

        private void Import_Check_state_Load(object sender, EventArgs e)
        {
            dtpDateStart.Value = DateTime.Now;
            dtpDateEnd.Value = DateTime.Now.AddMonths(1);
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "Check";
            chk.Width = 30;
            dataGridView2.Columns.Add(chk);

            Point headerLocation = dataGridView2.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox.Location = new Point(headerLocation.X + 8, headerLocation.Y + 6);
            headerCheckBox.BackColor = Color.FromArgb(55, 113, 138);
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += new EventHandler(HeaderCheckBox_Click);
            dataGridView2.Controls.Add(headerCheckBox);
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "No", "VO_ID", true, 70, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "검사일", "VOD_ResultDay", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "업체명", "COM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목", "ITEM_Code", true, 170);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품명", "ITEM_Name", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "규격", "ITEM_Size", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "최종결과", "VOD_Result", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "납품수량", "VOD_GoodEA", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "불량수량", "VOD_BadEA", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "비고", "", true, 150, DataGridViewContentAlignment.MiddleRight);

            cboResult.Items.Add("");
            cboResult.Items.Add("합격");
            cboResult.Items.Add("불합격");
            DataLoad();
            Datagridview();
            btnSearch_Click(null, new EventArgs());
        }

        public void Datagridview()
        {
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 113, 138);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersHeight = 30;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        }

            public void DataLoad()
        {
            ImportCheckSearchVO ics = new ImportCheckSearchVO();
            ics.startDate = dtpDateStart.Value.ToShortDateString();
            ics.endDate = dtpDateEnd.Value.ToShortDateString();
            ics.Company = cbocompany.Text.Trim();
            ics.Item = txtitem.Text.Trim();
            ics.Result = cboResult.Text.Trim();
            ics.Plan_ID = cboplanid.Text.Trim();

            PSM_Service service = new PSM_Service();
            list = service.ImportCheck(ics);
            dataGridView2.DataSource = list;
            
            List<CompanyCodeVO> company = service.GetAllCompanyCode();
            CommonUtil.ComboBinding(cbocompany, company, "COM_Code", "COM_Name", "");

            List<PlanIDVO> planid = service.CheckPlanID();           
            CommonUtil.ComboBinding(cboplanid, planid, "Plan_ID", "Plan_ID");



        }

        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox.Checked;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool isChecked = true;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue) == false)
                    {
                        isChecked = false;
                        break;
                    }
                }
                headerCheckBox.Checked = isChecked;
            }
        }

        private void btnCheck_OK_Click(object sender, EventArgs e)
        {
            List<DeleteOrder> lists = new List<DeleteOrder>();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                bool isCellChecked = Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue);

                if (isCellChecked)
                {
                    DeleteOrder list = new DeleteOrder();
                    list.VO_ID = Convert.ToInt32(row.Cells[1].Value);
                    lists.Add(list);
                }
            }
            PSM_Service service = new PSM_Service();
            service.Result(lists);

            DataLoad();
        }

        private void DtpDateEnd_ValueChanged(object sender, EventArgs e)
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
            ImportCheckSearchVO ics = new ImportCheckSearchVO();
            ics.startDate = dtpDateStart.Value.ToShortDateString();
            ics.endDate = dtpDateEnd.Value.ToShortDateString();
            ics.Company = cbocompany.Text.Trim();
            ics.Item = txtitem.Text.Trim();
            ics.Result = cboResult.Text.Trim();
            ics.Plan_ID = cboplanid.Text.Trim();

            PSM_Service service = new PSM_Service();
            list = service.ImportCheck(ics);            

            if (!(list.Count < 1))
            {
                dataGridView2.DataSource = list;
            }
            else
            {
                MessageBox.Show("검색 결과가 없습니다");
            }
        }

        private void txtitem_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                if (dataGridView2[7, j].Value.ToString() == "불합격")
                {
                    dataGridView2[7, j].Style.BackColor = Color.IndianRed;
                }
                else
                {
                    dataGridView2[7, j].Style.BackColor = Color.SkyBlue;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void cboplanid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar == 13))
            {
                btnSearch_Click(null, new EventArgs());
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
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
                                               
                xlWorkSheet.Cells[1, 1] = "No";
                xlWorkSheet.Cells[1, 2] = "검사일";
                xlWorkSheet.Cells[1, 3] = "업체명";
                xlWorkSheet.Cells[1, 4] = "품목";
                xlWorkSheet.Cells[1, 5] = "품명";
                xlWorkSheet.Cells[1, 6] = "규격";
                xlWorkSheet.Cells[1, 7] = "최종결과";
                xlWorkSheet.Cells[1, 8] = "납품수량";
                xlWorkSheet.Cells[1, 9] = "불량수량";
                xlWorkSheet.Cells[1, 10] = "비고";
              

                for (i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (j = 0; j < dataGridView2.ColumnCount - 1; j++)
                    {
                        if (dataGridView2[j, i].Value != null)
                            xlWorkSheet.Cells[i + 2, j + 1] = dataGridView2[j, i].Value.ToString();
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

        private void cboplanid_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] arrDate = cboplanid.Text.Split('_');
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
    }    
}
