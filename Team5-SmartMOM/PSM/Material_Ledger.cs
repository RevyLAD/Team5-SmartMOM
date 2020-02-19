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
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            chk = new DataGridViewCheckBoxColumn();
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

            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "No", "VO_ID", true, 70, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "업체이름", "COM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품명", "ITEM_Name", true, 170);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "규격", "ITEM_Size", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "단위", "ITEM_Unit", true, 80, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "발주수량", "VOD_GoodEA", true, 150, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "잔량", "FACD_Qty", true, 100, DataGridViewContentAlignment.MiddleRight);                        
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "납기일", "VO_EndDate", true, 100, DataGridViewContentAlignment.MiddleCenter);            
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "출발상태", "VOD_Result", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "주문상태", "MATERIAL_ORDER_STATE", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "생성일", "VOD_ResultDay", true, 150, DataGridViewContentAlignment.MiddleCenter);

            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            chk2 = new DataGridViewCheckBoxColumn();
            chk2.HeaderText = "";
            chk2.Name = "Check";
            chk2.Width = 30;
            dataGridView3.Columns.Add(chk2);

            Point headerLocation2 = dataGridView3.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox2.Location = new Point(headerLocation2.X + 8, headerLocation2.Y + 6);
            headerCheckBox2.BackColor = Color.FromArgb(55, 113, 138);
            headerCheckBox2.Size = new Size(18, 18);
            headerCheckBox2.Click += new EventHandler(HeaderCheckBox_Click2);
            dataGridView3.Controls.Add(headerCheckBox2);
            dataGridView3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "No", "VO_ID", true, 70, DataGridViewContentAlignment.MiddleRight);            
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "품명", "ITEM_Name", true, 170);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "규격", "ITEM_Size", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "품목유형", "ITEM_Type", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "단위", "ITEM_Unit", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "입고창고", "FACT_Name", true, 120, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "업체이름", "VO_InDate", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "입고량", "VOD_GoodEA", true, 120, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "단가", "ITEM_Price", true, 120, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "비고", "", true, 120);

            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            DataLoad();
            Datagridview();            
            BtnSearch_Click(null, new EventArgs());
        }

        public void Datagridview()
        {
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 113, 138);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersHeight = 30;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 113, 138);
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView3.ColumnHeadersHeight = 30;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        }

        public void DataLoad()
        {
            Material_LedgerSearchVO mls = new Material_LedgerSearchVO();
            mls.startDate = dtpDateStart.Value.ToShortDateString();
            mls.endDate = dtpDateEnd.Value.ToShortDateString();
            mls.Company = cbocompany.Text.Trim();
            mls.Item = txtitem.Text.Trim();
            mls.Plan_ID = cboplanid.Text.Trim();
            

            PSM_Service service = new PSM_Service();
            list = service.Material_Ledger(mls);
            dataGridView2.DataSource = list;
            
            list2 = service.Receiving_processing();
            dataGridView3.DataSource = list2;

            List<CompanyCodeVO> company = service.GetAllCompanyCode();
            CommonUtil.ComboBinding(cbocompany, company, "COM_Code", "COM_Name", "");

            List<PlanIDVO> planid = service.Material_Ledger_PlanID();
            CommonUtil.ComboBinding(cboplanid, planid, "Plan_ID", "Plan_ID");

        }
        #region 체크박스
        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox.Checked;
            }
        }

        private void HeaderCheckBox_Click2(object sender, EventArgs e)
        {
            dataGridView3.EndEdit();
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox2.Checked;
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

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                                              
                xlWorkSheet.Cells[1, 1] = "No";
                xlWorkSheet.Cells[1, 2] = "업체이름";
                xlWorkSheet.Cells[1, 3] = "품목";
                xlWorkSheet.Cells[1, 4] = "품명";
                xlWorkSheet.Cells[1, 5] = "규격";
                xlWorkSheet.Cells[1, 6] = "단위";
                xlWorkSheet.Cells[1, 7] = "발주수량";
                xlWorkSheet.Cells[1, 8] = "잔량";
                xlWorkSheet.Cells[1, 9] = "납기일";
                xlWorkSheet.Cells[1, 10] = "출발상태";
                xlWorkSheet.Cells[1, 11] = "주문상태";
                xlWorkSheet.Cells[1, 12] = "생성일";

                for (i = 0; i < dataGridView2.RowCount -2; i++)
                {
                    for (j = 0; j < dataGridView2.ColumnCount - 1; j++)
                    {
                        if(dataGridView2[j, i].Value != null)
                            xlWorkSheet.Cells[i + 1, j + 1] = dataGridView2[j, i].Value.ToString();
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
            bool bFlag = false;
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                if ((bool)dataGridView3.Rows[i].Cells["Check"].EditedFormattedValue)
                {
                    bFlag = true;
                    break;
                }
            }
            if (bFlag == false)
            {
                MessageBox.Show("입고하실 항목을 선택해주세요.");
                return;
            }
            List<MaterialInDateVO> lists = new List<MaterialInDateVO>();
            List<MaterialsPlusVO> lists2 = new List<MaterialsPlusVO>();
            List<InOutListVO> lists3 = new List<InOutListVO>();
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                bool isCellChecked = Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue);

                if (isCellChecked)
                {
                    MaterialInDateVO list = new MaterialInDateVO();
                    list.VO_ID = Convert.ToInt32(row.Cells[1].Value);
                    lists.Add(list);

                    MaterialsPlusVO list2 = new MaterialsPlusVO();
                    list2.VOD_GoodEA = Convert.ToInt32(row.Cells[9].Value);
                    list2.ITEM_Code = row.Cells[2].Value.ToString();
                    lists2.Add(list2);

                    InOutListVO list3 = new InOutListVO();
                    list3.InOut_Date = (DateTime)row.Cells[8].Value;
                    list3.In_WareHouse = row.Cells[7].Value.ToString();
                    list3.ITEM_Code = row.Cells[2].Value.ToString();
                    list3.InOut_Qty = Convert.ToInt32(row.Cells[9].Value);
                    lists3.Add(list3);

                    
                }
            }
            PSM_Service service = new PSM_Service();
            service.MaterialProcess(lists, lists2, lists3);
            MessageBox.Show("선택하신 항목들을 입고처리 하였습니다.");
            DataLoad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool bFlag = false;
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                if ((bool)dataGridView3.Rows[i].Cells["Check"].EditedFormattedValue)
                {
                    bFlag = true;
                    break;
                }
            }
            if (bFlag == false)
            {
                MessageBox.Show("취소하실 항목을 선택해주세요.");
                return;
            }
            if (MessageBox.Show("선택하신 항목을 취소하시겠습니까?", "취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<DeleteOrder> lists = new List<DeleteOrder>();
                foreach (DataGridViewRow row in dataGridView3.Rows)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bFlag = false;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if ((bool)dataGridView2.Rows[i].Cells["Check"].EditedFormattedValue)
                {
                    bFlag = true;
                    break;
                }
            }
            if (bFlag == false)
            {
                MessageBox.Show("입고하실 항목을 선택해주세요.");
                return;
            }
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
            service.MaterialsPut(lists);

            DataLoad();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Material_LedgerSearchVO mls = new Material_LedgerSearchVO();
            mls.startDate = dtpDateStart.Value.ToShortDateString();
            mls.endDate = dtpDateEnd.Value.ToShortDateString();
            mls.Company = cbocompany.Text.Trim();
            mls.Item = txtitem.Text.Trim();
            mls.Plan_ID = cboplanid.Text.Trim();

            PSM_Service service = new PSM_Service();
            list = service.Material_Ledger(mls);           

            if (!(list.Count < 1))
            {
                dataGridView2.DataSource = list;
            }
            else
            {
                MessageBox.Show("검색 결과가 없습니다");
                dataGridView2.DataSource = null;
            }
        }

        private void txtitem_KeyPress(object sender, KeyPressEventArgs e)
        {
           if ((e.KeyChar == 13))
            {
                BtnSearch_Click(null, new EventArgs());
            }
        }

        private void cboplanid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar == 13))
            {
                BtnSearch_Click(null, new EventArgs());
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
