using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using Project_VO.HSM;
using Team5_SmartMOM.Service;
using Excel = Microsoft.Office.Interop.Excel;

namespace Team5_SmartMOM.HSM
{
    public partial class Sales_Master_Upload : Team5_SmartMOM.BaseGridForm
    {
        public Sales_Master_Upload()
        {
            InitializeComponent();
        }
        private void Sales_Master_Upload_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "planDate", "planDate", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "WORK_ORDER_ID", "WORK_ORDER_ID", true, 180);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체CODE", "업체CODE", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주구분", "발주구분", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납품처", "납품처", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "ITEM CODE", "ITEM CODE", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "계획수량합계", "계획수량합계", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "납기일", true, 200);




        }

        private void button3_Click(object sender, EventArgs e) //영업마스터 업로드
        {
            
            MasterCreate frm = new MasterCreate();
            frm.StartPosition = FormStartPosition.CenterScreen;
            

            if(frm.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = frm.ExcelData;
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)//저장
        {
            List<SalesMasterVO> sales = new List<SalesMasterVO>();

            if(dataGridView1.RowCount > 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    SalesMasterVO sale = new SalesMasterVO();
                    sale.SALES_OrderDate = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    sale.SO_WorkOrderID = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    sale.COM_Code = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    sale.PO_Type = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    sale.ITEM_Code = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    sale.SALES_OrderQty = Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
                    sale.SALES_Duedate = dataGridView1.Rows[i].Cells[7].Value.ToString();

                    sales.Add(sale);
                }

                HSM_Service service = new HSM_Service();
                if (service.UploadSalesMaster(sales))
                {
                    MessageBox.Show("영업마스터가 저장되었습니다.");
                    dataGridView1.DataSource = null;
                }
                else
                {
                    MessageBox.Show("저장실패");
                }

            }
            else
            {
                MessageBox.Show("영업마스터를 먼저 업로드 하세요.");
            }

        }

        private void button2_Click(object sender, EventArgs e) //양식다운로드
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

                xlWorkSheet.Cells[1, 1] = "planDate";
                xlWorkSheet.Cells[1, 2] = "순번";
                xlWorkSheet.Cells[1, 3] = "WORK_ORDER_ID";
                xlWorkSheet.Cells[1, 4] = "업체CODE";
                xlWorkSheet.Cells[1, 5] = "납품처";
                xlWorkSheet.Cells[1, 6] = "발주구분";
                xlWorkSheet.Cells[1, 7] = "ITEM CODE";
                xlWorkSheet.Cells[1, 8] = "계획수량합계";
                xlWorkSheet.Cells[1, 9] = "납기일";




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

    }
}
