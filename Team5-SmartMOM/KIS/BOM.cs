using Project_VO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Team5_SmartMOM.BaseForm;
using Team5_SmartMOM.Service;
using Excel = Microsoft.Office.Interop.Excel;

namespace Team5_SmartMOM.KIS
{
    
    public partial class BOM : Team5_SmartMOM.BaseGridForm
    {
        CheckBox headerCheckBox = new CheckBox();
        List<BOM_VO> list;
        int type;
        public BOM()
        {
            InitializeComponent();
        }


        /// <summary>
        /// BOM의 신규 등록 팝업 생성 
        /// </summary> 
        private void Btn_newitem_Click_1(object sender, EventArgs e)
        {
            BOM_detail frm = new BOM_detail();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataLoad();
            }
        }
        /// <summary>
        /// 로드 되었을때의 이벤트
        /// ShowDataview는 그리드뷰에 대한 컬럼 add 
        /// DataLoad는 그리드뷰의 데이터 호출
        /// checkbox는 체크박스들에 대한 바인딩 호출 
        /// </summary>
        private void BOM_Load(object sender, EventArgs e)
        {
         

            string[] type = { "-", "정전개", "역전개" };
            cbo_Deployement.Items.AddRange(type);
            cbo_Deployement.SelectedIndex = 0;
            ShowGridView();

            DataLoad();
            CheckBox();
            CommonCodeService service1 = new CommonCodeService();

            List<CommonCodeVO> listGubunCode1 = service1.GetAllCommonCode();

            List<CommonCodeVO> OrderGubunList1 = (from item in listGubunCode1
                                                  where item.Common_Type == "USE_FLAG"
                                                  select item).ToList();
         //   CommonUtil.ComboBinding(cbo_UseorNot, OrderGubunList1, "Common_Key", "Common_Value");
        }
        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells[""] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox.Checked;
            }
        }
        private void ShowGridView()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn(false);

            checkBoxColumn.Name = "";
            checkBoxColumn.Width = 30;
            
            dataGridView1.Columns.Add(checkBoxColumn);

            Point headerLocation = dataGridView1.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox.Location = new Point(headerLocation.X + 8, headerLocation.Y + 6);
            headerCheckBox.BackColor = Color.White;
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += new EventHandler(HeaderCheckBox_Click);
            dataGridView1.Controls.Add(headerCheckBox);

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "NO", "BOM_No", false, 50);
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "상위품목", "BOM_Code", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 130);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소요량", "BOM_Require", true, 90);
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시작일", "BOM_StartDate", true, 120);
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "종료일", "BOM_EndDate", true, 120);
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "BOM_UseOrNot", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "BOM_Modifier", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정시간", "BOM_ModifiyDate", true, 120);
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "자동차감", "BOM_AutoDeduction", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소요계획", "BOM_RequirePlan", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "BOM_Others", true, 140);
            dataGridView1.AllowUserToAddRows = false;
      

        }
        private void ShowGridView2()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn(false);
            checkBoxColumn.Width = 30;

            dataGridView1.Columns.Add(checkBoxColumn);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "NO", "BOM_No", false, 50);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "상위품목", "BOM_Code", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 170);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "유형", "ITEM_Type", true, 70);  
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "타입", "Levels", true, 70);
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소요량", "BOM_Require", true, 80);
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시작일", "BOM_StartDate", true, 120);
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "종료일", "BOM_EndDate", true, 120);
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "BOM_UseOrNot", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "BOM_Modifier", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정시간", "BOM_ModifiyDate", true, 120);
            dataGridView1.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "자동차감", "BOM_AutoDeduction", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소요계획", "BOM_RequirePlan", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "BOM_Others", true, 140);
         
            dataGridView1.AllowUserToAddRows = false;
        }
        private void CheckBox()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = true;
            }
        }
        /// <summary>
        /// datagridview에 대한 체크박스 이벤트 
        /// 컬럼을 선택할때마다 for문을 돌려 선택된 열의 value값을 true로 만든다. 
        /// </summary>
        private void DataGridView1_CheckBoxValue(object sender, DataGridViewRowEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = true;
                //DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[1];
                //cell.Value = true;
            }
        }

        public void DataLoad()
        {
            KIS_Service service = new KIS_Service();
            
            list = service.ShowBOM();

            dataGridView1.DataSource = list;


        }

        /// <summary>
        ///DataGridView1_CheckBoxValue에서 true/false를 받은 값을 조회하며 
        ///조회된 값을 리스트에 저장 
        ///이후 리스트에 있는 값을 string.join을 이용하여 한번에 보낸후 
        ///db에서 삭제한다.
        /// </summary>
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            KIS_Service service = new KIS_Service();
            List<string> list = new List<string>();
            bool check = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    list.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }
            if (list.Count == 0)
            {
                MessageBox.Show("삭제할 품목을 선택해 주시기 바랍니다.");
                check = false;

            }
            else if (check)
            {
                string.Join(",", list.ToArray());
                bool bResult = service.DeleteBOM(string.Join(",", list));

                if (bResult)
                {
                    MessageBox.Show("성공적으로 삭제되었습니다");
                    DataLoad();
                }
                else
                {
                    MessageBox.Show("등록중 오류가 발생하였습니다 다시 시도해주세요");
                }
            }
        }
        /// <summary>
        /// 텍스트박스에 있는 데이터를 가져온 후 
        ///  db의 재귀쿼리를 넘어가 데이터를 받아온 후 
        ///  4중 for문을 돌려 db에서 받은 데이터를 하나씩 받으면서 첫번째 for문의 i값을 증가
        ///  반제품과 원자재는 trim을 이용하여 앞의 분간점을 제외한 후 확인하면서 리스트에 저장 
        ///  for문이 종료되면 리스트에 있는 값을 datagridview의 datasource에 출력 
        /// </summary>
        private void Btn_Search_Click(object sender, EventArgs e)
        {
         
            SearchBOM();
        }

        private void SearchBOM()
        {
            if (cbo_Deployement.Text == "-")
            {
                MessageBox.Show("전개 방식을 선택해 주시기 바랍니다.");
            }

            else if (cbo_Deployement.Text == "정전개")
            {
                type = 1;
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();


                List<BOM_Serch_VO> list = new List<BOM_Serch_VO>();
                KIS_Service service = new KIS_Service();
                list = BomSearch(list, service);
              

            }
            else if (cbo_Deployement.Text == "역전개")
            {
                type = 2;
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();


                List<BOM_Serch_VO> list = new List<BOM_Serch_VO>();
                KIS_Service service = new KIS_Service();
                list = BomSearch(list, service);
            }
        }

        private List<BOM_Serch_VO> BomSearch(List<BOM_Serch_VO> list, KIS_Service service)
        {
            if (txt_Item.Text == null)
            {
                MessageBox.Show("품목을 입력하세요");
            }
            else
            {
                List<BOM_Serch_VO> list2 = new List<BOM_Serch_VO>();
                list = service.SearchBOM(txt_Item.Text, type , dtp_ExistingDate.Value.ToString("yyyy-MM-dd"));


                //List<BOM_Serch_VO> BOM_List = (from item in list where item)
                char[] aar = { '└', '─' };

                if (type == 1)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].ITEM_Code == txt_Item.Text && list2.Count == 0)
                        {
                            list2.Add(list[i]);
                            i++;
                        }
                        for (int j = 0; j < list.Count; j++)
                        {
                            if (list[j].BOM_Code == txt_Item.Text && list[j].Levels == 1)
                            {
                                list2.Add(list[j]);
                                i++;
                                for (int k = 0; k < list.Count; k++)
                                {
                                    if (list[k].BOM_Code == list[j].ITEM_Code.Replace("└", "").Replace("'─", "").Trim() && list[k].Levels == 2)
                                    {
                                        list2.Add(list[k]);
                                        i++;
                                        for (int m = 0; m < list.Count; m++)
                                        {
                                            if (list[m].BOM_Code == list[k].ITEM_Code.Replace("└", "").Replace("─", "").Trim() && list[m].Levels == 3)
                                            {
                                                list2.Add(list[m]);
                                                i++;
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                    ShowGridView2();
                    if (list.Count != 0)
                    {
                        dataGridView1.DataSource = list2;
                    }
                    else
                    {
                        MessageBox.Show("결과 없음.");
                    }
                }
                else if (type == 2)
                {
                    //for (int i = 0; i < list.Count; i++)
                    //{
                    //    if (list[i].ITEM_Code.Replace("└", "").Replace("'─", "").Trim() == txt_Item.Text && list2.Count == 0)
                    //    {
                    //        list2.Add(list[i]);

                    //    }
                    //    for (int j = 0; j < list.Count; j++)
                    //    {
                    //        if (list[j].ITEM_Code.Replace("└", "").Replace("'─", "").Trim() == list[i].BOM_Code)
                    //        {
                    //            list2.Add(list[j]);
                    //            i++;
                    //        }
                    //        for (int k = 0; k < list.Count; k++)
                    //        {
                    //            if (list[k].ITEM_Code.Replace("└", "").Replace("'─", "").Trim() == list[j].BOM_Code)
                    //            {
                    //                list2.Add(list[k]);
                    //                i++;
                    //            }
                    //            for (int m = 0; m < list.Count; m++)
                    //            {
                    //                if (list[m].ITEM_Code.Replace("└", "").Replace("'─", "").Trim() == list[k].BOM_Code && list[m].Levels == 3)
                    //                {
                    //                    list2.Add(list[m]);
                    //                    i++;

                    //                }
                    //            }
                    //        }
                    //    }
                    //}
                    ShowGridView2();
                    if (list.Count != 0)
                    {
                        dataGridView1.DataSource = list;
                    }
                   else
                    {
                        MessageBox.Show("결과 없음.");
                    }

                }

            }
            return list;
        }




        private void Btn_Copy_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 13)
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
                    int row = 2;
                    xlWorkSheet.Cells[1, 1] = "상위품목";
                    xlWorkSheet.Cells[1, 2] = "품목";
                    xlWorkSheet.Cells[1, 3] = "소요량";
                    xlWorkSheet.Cells[1, 4] = "시작일";
                    xlWorkSheet.Cells[1, 5] = "종료일";
                    xlWorkSheet.Cells[1, 6] = "사용유무";
                    xlWorkSheet.Cells[1, 7] = "자동차감";
                    xlWorkSheet.Cells[1, 8] = "소요계획";
                    xlWorkSheet.Cells[1, 9] = "비고";



                    foreach (DataGridViewRow temp in dataGridView1.Rows)
                    {
                        xlWorkSheet.Cells[row, 1] = temp.Cells[2].Value.ToString();
                        xlWorkSheet.Cells[row, 2] = temp.Cells[3].Value.ToString();
                        xlWorkSheet.Cells[row, 3] = temp.Cells[4].Value.ToString();
                        xlWorkSheet.Cells[row, 4] = temp.Cells[5].Value.ToString();
                        xlWorkSheet.Cells[row, 5] = temp.Cells[6].Value.ToString();
                        xlWorkSheet.Cells[row, 6] = temp.Cells[7].Value.ToString();
                        xlWorkSheet.Cells[row, 7] = temp.Cells[10].Value.ToString();
                        xlWorkSheet.Cells[row, 8] = temp.Cells[11].Value.ToString();
                        row++;
                    }

                    xlWorkBook.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal);
                    xlWorkBook.Close(true);
                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);
                }
            }
            else if (dataGridView1.Columns.Count == 15)
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
                    int row = 2;
                    xlWorkSheet.Cells[1, 1] = "상위품목";
                    xlWorkSheet.Cells[1, 2] = "품목";
                    xlWorkSheet.Cells[1, 3] = "소요량";
                    xlWorkSheet.Cells[1, 4] = "시작일";
                    xlWorkSheet.Cells[1, 5] = "종료일";
                    xlWorkSheet.Cells[1, 6] = "사용유무";
                    xlWorkSheet.Cells[1, 7] = "자동차감";
                    xlWorkSheet.Cells[1, 8] = "소요계획";
                    xlWorkSheet.Cells[1, 9] = "비고";



                    foreach (DataGridViewRow temp in dataGridView1.Rows)
                    {
                        xlWorkSheet.Cells[row, 1] = temp.Cells[1].Value.ToString();
                        xlWorkSheet.Cells[row, 2] = temp.Cells[2].Value.ToString();
                        xlWorkSheet.Cells[row, 3] = temp.Cells[6].Value.ToString();
                        xlWorkSheet.Cells[row, 4] = temp.Cells[7].Value.ToString();
                        xlWorkSheet.Cells[row, 5] = temp.Cells[8].Value.ToString();
                        xlWorkSheet.Cells[row, 6] = temp.Cells[9].Value.ToString();
                        xlWorkSheet.Cells[row, 7] = temp.Cells[12].Value.ToString();
                        xlWorkSheet.Cells[row, 8] = temp.Cells[13].Value.ToString();
                        //xlWorkSheet.Cells[row, 9] = temp.Cells[14].Value.ToString();
                        row++;
                    }

                    xlWorkBook.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal);
                    xlWorkBook.Close(true);
                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);
                }
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

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            ShowGridView();
            dataGridView1.DataSource = list;
        }
    }
}
