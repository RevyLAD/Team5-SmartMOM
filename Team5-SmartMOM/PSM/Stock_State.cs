using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.PSM
{
    public partial class Stock_State : Team5_SmartMOM.BaseGridForm
    {
        CheckBox headerCheckBox = new CheckBox();
        List<Stock_StateVO> list = new List<Stock_StateVO>();
        public Stock_State()
        {
            InitializeComponent();
        }

        private void Stock_State_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
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
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "창고코드", "FACT_Code", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "창고", "FACT_Name", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목타입", "ITEM_Type", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "재고량", "FACD_Qty", true, 150, DataGridViewContentAlignment.MiddleRight);            
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "단위", "ITEM_Unit", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "관리등급", "", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "", true, 150);
            
            btnSearch_Click(null, new EventArgs());
            DataLoad();
        }

        public void DataLoad()
        {
            MaterialStateVO ms = new MaterialStateVO();
            ms.FACT_Name = cbofactory.Text.Trim();
            ms.ITEM_Name = txtitem.Text.Trim();

            PSM_Service service = new PSM_Service();
            list = service.Stock_State(ms);
            dataGridView1.DataSource = list;

            
            List<FacVO> planid = service.GetFactoryList();
            CommonUtil.ComboBinding(cbofactory, planid, "FACT_Code", "FACT_Name", "");
        }

            private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox.Checked;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MaterialStateVO ms = new MaterialStateVO();
            ms.FACT_Name = cbofactory.Text.Trim();
            ms.ITEM_Name = txtitem.Text.Trim();

            PSM_Service service = new PSM_Service();
            list = service.Stock_State(ms);            

            if (!(list.Count < 1))
            {
                dataGridView1.DataSource = list;
            }
            else
            {
                MessageBox.Show("검색 결과가 없습니다");
            }


        }

        private void txtitem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13))
            {
                btnSearch_Click(null, new EventArgs());
            }
        }

        private void cbofactory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar == 13))
            {
                btnSearch_Click(null, new EventArgs());
            }
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

                xlWorkSheet.Cells[1, 1] = "창고코드";
                xlWorkSheet.Cells[1, 2] = "창고";
                xlWorkSheet.Cells[1, 3] = "품목";
                xlWorkSheet.Cells[1, 4] = "품명";
                xlWorkSheet.Cells[1, 5] = "품목타입";
                xlWorkSheet.Cells[1, 6] = "재고량";
                xlWorkSheet.Cells[1, 7] = "단위";
                xlWorkSheet.Cells[1, 8] = "관리등급";
                xlWorkSheet.Cells[1, 9] = "비고";
          

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
