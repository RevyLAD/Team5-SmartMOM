using DevExpress.Utils.CommonDialogs;
using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;
using Microsoft.Office.Interop.Excel;
using Team5_SmartMOM.BaseForm;
using Team5_Pop;

namespace Team5_SmartMOM
{
    public partial class BOR : Team5_SmartMOM.BaseGridForm
    {
        public BOR()
        {
            InitializeComponent();
        }

        List<BORVO> list;
        private void button3_Click(object sender, EventArgs e)
        {
            BORRegister frm = new BORRegister();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            DataLoad();
        }

        private void DataLoad()
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "번호", "BOR_No", true, 50);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비군코드", "FACG_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비코드", "FAC_Code", true, 170);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "생산소요시간", "BOR_TactTime", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "우선순위", "BOR_Priority", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "BOR_UseOrNot", true, 350);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수율", "BOR_yeild", true, 250);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "BOR_Ohters", true, 208);

            HSC_Service service = new HSC_Service();
            dataGridView1.DataSource = list = service.GetAllBOR();
        }

        private void BOR_Load(object sender, EventArgs e)
        {
            DataLoad();

            PopService service = new PopService();
            CommonUtil.ComboBinding(cboFacCrow, service.GetFACName(), "FAC_Code", "FAC_Name");

            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<BORVO> newlist = new List<BORVO>();

            if (textBox1.Text.Trim() == "" &&
                textBox2.Text.Trim() == "" &&
                cboFacCrow.Text.Trim() == "")
            {
                MessageBox.Show("검색어를 입력해주세요");
            }
            else
            {
                foreach (var li in list)
                {
                    if (Convert.ToString(li.ITEM_Code).Trim().Contains(textBox1.Text.Trim()) &&
                        li.FACG_Code.Trim().Contains(cboFacCrow.Text.Trim()) &&
                        li.FAC_Code.Trim().Contains(textBox2.Text.Trim()))
                        newlist.Add(li);
                }
                dataGridView1.DataSource = newlist;
                dataGridView1.DataSource = SearchBOR();
            }
        }

        private List<BORVO> SearchBOR()
        {
            List<BORVO> newlist = new List<BORVO>();

            foreach (var li in list)
            {
                if (Convert.ToString(li.ITEM_Code).Trim().Contains(textBox1.Text.Trim()) &&
                        li.FAC_Code.Trim().Contains(textBox2.Text.Trim()) &&
                        li.FACG_Code.Trim().Contains(cboFacCrow.Text.Trim()))
                    newlist.Add(li);
            }

            return newlist;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                BORVO vo = new BORVO();
                vo.ITEM_Code = dataGridView1.Rows[temp.RowIndex].Cells[1].Value.ToString();
                vo.FACG_Code = dataGridView1.Rows[temp.RowIndex].Cells[2].Value.ToString();
                vo.FAC_Code = dataGridView1.Rows[temp.RowIndex].Cells[3].Value.ToString();
                vo.BOR_TactTime = Convert.ToInt32(dataGridView1.Rows[temp.RowIndex].Cells[4].Value.ToString());
                vo.BOR_Priority = Convert.ToInt32(dataGridView1.Rows[temp.RowIndex].Cells[5].Value.ToString());
                vo.BOR_UseOrNot = dataGridView1.Rows[temp.RowIndex].Cells[6].Value.ToString();
                vo.BOR_yeild = Convert.ToInt32(dataGridView1.Rows[temp.RowIndex].Cells[7].Value);
                vo.BOR_No = Convert.ToInt32(dataGridView1.Rows[temp.RowIndex].Cells[0].Value);
                vo.BOR_Ohters = dataGridView1.Rows[temp.RowIndex].Cells[8].Value?.ToString() ?? null;

                BORRegister frm = new BORRegister(vo);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                DataLoad();
            }
            else
            {
                MessageBox.Show("수정할 BOR을 선택해주세요");
            }
        }
        DataGridViewCellEventArgs temp;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = e;
        }

        private void metroButton2_Click(object sender, EventArgs e)
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

                xlWorkSheet.Cells[1, 1] = "품목";
                xlWorkSheet.Cells[1, 2] = "설비군 코드";
                xlWorkSheet.Cells[1, 3] = "설비 코드";
                xlWorkSheet.Cells[1, 4] = "우선 순위";
                xlWorkSheet.Cells[1, 5] = "사용 유무";
                xlWorkSheet.Cells[1, 6] = "수율";
                xlWorkSheet.Cells[1, 7] = "비고";

                for (i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (j = 0; j < dataGridView1.ColumnCount - 1; j++)
                    {
                        if(dataGridView1[j, i].Value != null)
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

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                if (MessageBox.Show("정말 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    HSC_Service service = new HSC_Service();
                    service.DeleteBOR(Convert.ToInt32(dataGridView1.Rows[temp.RowIndex].Cells[0].Value));
                    DataLoad();
                }
            }
            else
            {
                MessageBox.Show("삭제할 BOR을 선택해주세요");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}
