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
    public partial class DeadLineState : Form
    {
        List<DeadLineVO> list;
        
        public DeadLineState()
        {
            InitializeComponent();
        }

        private void DeadLineState_Load(object sender, EventArgs e)
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "고객주문번호", "SO_WorkOrderID", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "PO NO", "", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "고객사코드", "COM_Code", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "고객사", "COM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "도착지코드", "COM_Code", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "도착지명", "COM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품명", "ITEM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "주문수량", "SALES_OrderQty", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "출하수량", "SALES_OrderQty", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "매출확정수량", "SALES_ShipQty", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "매출확정금액", "Price", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "마감일자", "DeadLine_Date", true, 100, DataGridViewContentAlignment.MiddleCenter);


            DataLoad();
            Datagridview();
        }

        public void DataLoad()
        {
            PSM_Service service = new PSM_Service();

            List<PlanIDVO> planid = service.PlanID4();
            CommonUtil.ComboBinding(cboplanid, planid, "Plan_ID", "Plan_ID");

            List<CompanyCodeVO> company = service.GetAllCompanyCode2();
            CommonUtil.ComboBinding(cbocompany, company, "COM_Code", "COM_Name", "");

            ShipmentOrderSearchVO so = new ShipmentOrderSearchVO();
            so.Company = cbocompany.Text.Trim();
            so.Item = txtitem.Text.Trim();
            so.Plan_ID = cboplanid.Text.Trim();

            list = service.DeadLineState(so);
            dataGridView2.DataSource = list;
        }

        public void Datagridview()
        {
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 113, 138);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersHeight = 30;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShipmentOrderSearchVO so = new ShipmentOrderSearchVO();
            so.Company = cbocompany.Text.Trim();
            so.Item = txtitem.Text.Trim();
            so.Plan_ID = cboplanid.Text.Trim();

            PSM_Service service = new PSM_Service();
            list = service.DeadLineState(so);
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

        private void button9_Click(object sender, EventArgs e)
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
                               
                xlWorkSheet.Cells[1, 1] = "고객주문번호";
                xlWorkSheet.Cells[1, 2] = "PO NO";
                xlWorkSheet.Cells[1, 3] = "고객사코드";
                xlWorkSheet.Cells[1, 4] = "고객사";
                xlWorkSheet.Cells[1, 5] = "도착지코드";
                xlWorkSheet.Cells[1, 6] = "도착지명";
                xlWorkSheet.Cells[1, 7] = "품목";
                xlWorkSheet.Cells[1, 8] = "품명";
                xlWorkSheet.Cells[1, 9] = "주문수량";
                xlWorkSheet.Cells[1, 10] = "출하수량";
                xlWorkSheet.Cells[1, 11] = "매출확정수량";
                xlWorkSheet.Cells[1, 12] = "매출확정금액";
                xlWorkSheet.Cells[1, 13] = "마감일자";

                for (i = 0; i < dataGridView2.RowCount -2; i++)
                {
                    for (j = 0; j < dataGridView2.ColumnCount - 1; j++)
                    {
                        if (dataGridView2[j, i].Value != null)
                            xlWorkSheet.Cells[i + 1, j + 1] = dataGridView2[j, i].Value.ToString();
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
