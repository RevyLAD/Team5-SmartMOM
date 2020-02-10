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
using Excel = Microsoft.Office.Interop.Excel;

namespace Team5_SmartMOM.PSM
{
    public partial class Material_Ledger : Form
    {
        CheckBox headerCheckBox = new CheckBox();
        CheckBox headerCheckBox2 = new CheckBox();
        DataGridViewCheckBoxColumn chk;
        DataGridViewCheckBoxColumn chk2;
        List<Material_LedgerVO> list = new List<Material_LedgerVO>();
        List<Receiving_processingVO> list2 = new List<Receiving_processingVO>();
        public Material_Ledger()
        {
            InitializeComponent();
        }

        private void Material_Ledger_Load(object sender, EventArgs e)
        {
            dtpDateStart.Value = DateTime.Now;
            dtpDateEnd.Value = DateTime.Now.AddMonths(1);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "Check";
            chk.Width = 30;
            dataGridView1.Columns.Add(chk);

            Point headerLocation = dataGridView1.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox.Location = new Point(headerLocation.X + 8, headerLocation.Y + 6);
            headerCheckBox.BackColor = Color.White;
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += new EventHandler(HeaderCheckBox_Click);
            dataGridView1.Controls.Add(headerCheckBox);

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "VO_ID", true, 70);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체이름", "COM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 170);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "단위", "ITEM_Unit", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주수량", "VOD_GoodEA", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "잔량", "FACD_Qty", true, 120);                        
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "VO_EndDate", true, 100);            
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "출발상태", "VOD_Result", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주문상태", "MATERIAL_ORDER_STATE", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "생성일", "VOD_ResultDay", true, 150);

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            chk2 = new DataGridViewCheckBoxColumn();
            chk2.HeaderText = "";
            chk2.Name = "Check";
            chk2.Width = 30;
            dataGridView2.Columns.Add(chk2);

            Point headerLocation2 = dataGridView2.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox2.Location = new Point(headerLocation2.X + 8, headerLocation2.Y + 6);
            headerCheckBox2.BackColor = Color.White;
            headerCheckBox2.Size = new Size(18, 18);
            headerCheckBox2.Click += new EventHandler(HeaderCheckBox_Click2);
            dataGridView2.Controls.Add(headerCheckBox2);

            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "No", "VO_ID", true, 70);            
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품명", "ITEM_Name", true, 170);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "규격", "ITEM_Size", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목유형", "ITEM_Type", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "단위", "ITEM_Unit", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "입고창고", "FACT_Name", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "업체이름", "VO_InDate", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "입고량", "VOD_GoodEA", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "단가", "ITEM_Price", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "비고", "", true, 120);

            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            DataLoad();
            Datagridview();
        }

        public void Datagridview()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 113, 138);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 113, 138);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersHeight = 30;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        }

        public void DataLoad()
        {
            Material_LedgerSearchVO mls = new Material_LedgerSearchVO();
            mls.startDate = dtpDateStart.Value.ToShortDateString();
            mls.endDate = dtpDateEnd.Value.ToShortDateString();
            mls.Company = cbocompany.Text.Trim();
            mls.Item = txtitem.Text.Trim();

            PSM_Service service = new PSM_Service();
            list = service.Material_Ledger(mls);
            dataGridView1.DataSource = list;

            PSM_Service service2 = new PSM_Service();
            list2 = service.Receiving_processing();
            dataGridView2.DataSource = list2;

        }
        #region 체크박스
        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox.Checked;
            }
        }

        private void HeaderCheckBox_Click2(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox2.Checked;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool isChecked = true;
                foreach (DataGridViewRow row in dataGridView1.Rows)
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool isChecked = true;
                foreach (DataGridViewRow row in dataGridView1.Rows)
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

        #endregion

        #region 엑셀
        private void btnexcel_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;

            int i, j;

            saveFileDialog1.Filter = "Excel Files (*.xls)|*.xls";
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                for (i = 0; i <= dataGridView1.RowCount - 2; i++)
                {
                    for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                    {
                        xlWorkSheet.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();
                    }
                }

                xlWorkBook.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal);
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
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            List<DeleteOrder> lists = new List<DeleteOrder>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
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
            service.MaterialsPut(lists);

            DataLoad();
        }

        private void button2_Click(object sender, EventArgs e)
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
            service.MaterialsPutCancel(lists);

            DataLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<DeleteOrder> lists = new List<DeleteOrder>();
            List<MaterialsPlusVO> lists2 = new List<MaterialsPlusVO>();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                bool isCellChecked = Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue);

                if (isCellChecked)
                {
                    DeleteOrder list = new DeleteOrder();
                    list.VO_ID = Convert.ToInt32(row.Cells[1].Value);
                    lists.Add(list);

                    MaterialsPlusVO list2 = new MaterialsPlusVO();
                    list2.VOD_GoodEA = Convert.ToInt32(row.Cells[9].Value);
                    list2.ITEM_Code = row.Cells[2].Value.ToString();
                    lists2.Add(list2);
                }
            }
            PSM_Service service = new PSM_Service();
            service.MaterialProcess(lists, lists2);

            DataLoad();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Material_LedgerSearchVO mls = new Material_LedgerSearchVO();
            mls.startDate = dtpDateStart.Value.ToShortDateString();
            mls.endDate = dtpDateEnd.Value.ToShortDateString();
            mls.Company = cbocompany.Text.Trim();
            mls.Item = txtitem.Text.Trim();

            PSM_Service service = new PSM_Service();
            list = service.Material_Ledger(mls);
            dataGridView1.DataSource = list;
        }
    }
}
