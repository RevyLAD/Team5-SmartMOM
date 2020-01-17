using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Team5_SmartMOM.HSM
{
    public partial class MasterCreate : Team5_SmartMOM.BasePopUpDialog
    {
        // 엑셀 변수 선언
        Excel.Application xlApp = null;
        Excel.Workbook xlWorkbook = null;
        Excel.Worksheet xlWorksheet = null;


        DataTable excelData = new DataTable();
        public DataTable ExcelData
        {
            get => excelData;
            set { this.excelData = value; }

        }
        public MasterCreate()
        {
            InitializeComponent();
        }

        private void btnFindFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel File (*.xlsx)|*.xlsx|Excel File 97~2003 (*.xls)|*.xls|All Files (*.*)|*.*";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// 영업마스터 업로드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtFileName.Text.Length <0)
            {
                MessageBox.Show("파일을 선택해주세요.","오류");
            }

            else
            {
                try
                {

                    // 엑셀데이터를 담을 데이터테이블 선언
                    DataTable dt = new DataTable();

                    // 엑셀 변수들 초기화   
                    xlApp = new Excel.Application();
                    xlWorkbook = xlApp.Workbooks.Open(txtFileName.Text);
                    xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1); // 첫 번째 시트

                    // 시트에서 범위 설정
                    // UsedRange는 사용된 셀 모두이므로 
                    // 범위를 따로 지정하려면 
                    // xlWorksheet.Range[xlWorksheet.Cells[시작 행, 시작 열], xlWorksheet.Cells[끝 행, 끝 열]]
                    Excel.Range range = xlWorksheet.UsedRange;

                    // 2차원 배열에 담기
                    object[,] data = range.Value;

                    // 데이터테이블에 엑셀 칼럼만큼 칼럼 추가
                    for (int i = 1; i <= range.Columns.Count; i++)
                    {
                        dt.Columns.Add(i.ToString(), typeof(string));
                    }

                    // 데이터테이블에 2차원 배열에 담은 엑셀데이터 추가
                    for (int r = 1; r < range.Rows.Count; r++)
                    {
                        DataRow dr = dt.Rows.Add();

                        for (int c = 1; c < range.Columns.Count; c++)
                        {
                            dr[c - 1] = data[r, c];
                        }
                    }

                    xlWorkbook.Close(true);
                    xlApp.Quit();

                    // 데이터그리드뷰에 데이터테이블 바인딩
                    this.excelData = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // 사용이 끝난 엑셀파일 Release
                    ReleaseExcelObject(xlWorksheet);
                    ReleaseExcelObject(xlWorkbook);
                    ReleaseExcelObject(xlApp);

                    this.DialogResult = DialogResult.OK;
                }

            }
        }

        private void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }

        
    }
}
