using Project_VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM
{
    public partial class BOM : Team5_SmartMOM.BaseGridForm
    {
        public BOM()
        {
            InitializeComponent();
        }



        private void Btn_newitem_Click_1(object sender, EventArgs e)
        {
            BOM_detail frm = new BOM_detail();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataLoad();
            }
        }

        private void BOM_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn(false);
            checkBoxColumn.HeaderText = "Check";
            checkBoxColumn.Name = "check";

            dataGridView1.Columns.Add(checkBoxColumn);


            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "BOM_No", true, 40);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "상위품목", "BOM_Code", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소요량", "BOM_Require", true, 70);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시작일", "BOM_StartDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "종료일", "BOM_EndDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "BOM_UseOrNot", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "BOM_Modifier", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정시간", "BOM_ModifiyDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "자동차감", "BOM_AutoDeduction", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소요계획", "BOM_RequirePlan", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "BOM_Others", true, 140);
            dataGridView1.AllowUserToAddRows = false;



            DataLoad();
            CheckBox();
        }


        private void CheckBox()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = true;
            }
        }
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
            List<BOM_VO> list = new List<BOM_VO>();
            list = service.ShowBOM();

            dataGridView1.DataSource = list;


        }

        //private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    if ((e.RowIndex > -1) && e.ColumnIndex == 1)
        //    {
        //        if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
        //        bool bFlag = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        //        //dataGridView1.Columns[1] is DataGridViewCheckBoxColumn 

        //    }
        //}

        private void Button6_Click(object sender, EventArgs e)
        {
            KIS_Service service = new KIS_Service();
            List<string> list = new List<string>();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    list.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }
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

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            List<BOM_Serch_VO> list = new List<BOM_Serch_VO>();
            KIS_Service service = new KIS_Service();
            if (txt_Item.Text == null)
            {
                MessageBox.Show("품목을 입력하세요");
            }
            else
            {
                List<BOM_Serch_VO> list2 = new List<BOM_Serch_VO>();
                list = service.SearchBOM(txt_Item.Text);


                //List<BOM_Serch_VO> BOM_List = (from item in list where item)



                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ITEM_Code == txt_Item.Text && list2.Count == 0)
                    {
                        list2.Add(list[i]);
                        i++;
                    }
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j].BOM_Code == txt_Item.Text && list[j].Levels==1)
                        {
                            list2.Add(list[j]);
                            i++;
                            for (int k = 0; k < list.Count; k++)
                            {
                                if (list[k].BOM_Code == list[j].ITEM_Code.Trim('ㆍ') && list[k].Levels==2)
                                {
                                    list2.Add(list[k]);
                                    i++;
                                    for (int m = 0; m < list.Count; m++)
                                    {
                                        if (list[m].BOM_Code == list[k].ITEM_Code.Trim('ㆍ') && list[m].Levels == 3)
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
                dataGridView1.DataSource = list2;
            }

        }
    }
}


