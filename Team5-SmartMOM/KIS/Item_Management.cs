using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.KIS
{
    public partial class Item_Management : Team5_SmartMOM.BaseGridForm
    {
        public Item_Management()
        {
            InitializeComponent();

        }

        private void Btn_newitem_Click(object sender, EventArgs e)
        {
            Item_Management_detail frm = new Item_Management_detail();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataLoad();
            }
        }

        private void Item_Management_Load(object sender, EventArgs e)
        {
            LoadPage();
        }

        private void LoadPage()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Width = 40;
            chk.HeaderText = "";

            //dataGridView1.CellClick += new DataGridViewCellEventHandler(DataGridView1_CellClick);




            dataGridView1.Columns.Add(chk);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "번호", "ITEM_No", true, 40);
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "단위", "ITEM_Unit", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목유형", "ITEM_Type", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수입검사여부", "ITEM_ImportIns", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "공정검사여부", "ITEM_ProcessIns", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "출하검사여부", "ITEM_ShipmentIns", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주업체", "ITEM_OrderComp", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "입고창고", "ITEM_InWarehouse", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "출고창고", "ITEM_OutWarehouse", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "최소발주수량", "ITEM_MinOrderQuantity", true, 120);
            dataGridView1.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "안전재고수량", "ITEM_SafeQuantity", true, 120);
            dataGridView1.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "관리등급", "ITEM_Grade", true, 80);
            dataGridView1.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "담당자", "ITEM_Manager", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "ITEM_Modifier", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정시간", "ITEM_ModifiyDate", true, 100);
            dataGridView1.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "ITEM_UserOrNot", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주방식", "ITEM_OrderMethod", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "ITEM_Others", true, 140);
            DataLoad();
        }

        public void DataLoad()
        {
            KIS_Service service = new KIS_Service();
            dataGridView1.DataSource = service.ShowITEM();
            //dataGridView1.ReadOnly = true;
        }
       
        /// <summary>
        /// datagridview에 있는 수정 버튼을 클릭할 경우 
        /// 선택된 열의 행을 확인하여 선택된 행의 readonly를 true로 하여 수정모드가 작동했다는것을 알려주며 
        /// 이후 버튼을 한번 더 클릭하면 수정모드가 종료되며 수정된 행의 값이 update가 된다. 
        /// </summary>       
        //private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex < 0)
        //        return;

        //    //if (dataGridView1.CurrentCell.ColumnIndex == 2 && checklist == false)
        //    //{
        //    //    MessageBox.Show("수정모드가 작동합니다. \n 셀을 클릭하여 타입에 알맞게 수정하시고 수정후 버튼을 클릭해주세요.");
        //    //    checklist = true;
        //    //    for (int i = 0; i < dataGridView1.ColumnCount; i++)
        //    //    {
        //    //        dataGridView1.Rows[e.RowIndex].Cells[i].ReadOnly = false;
        //    //        dataGridView1.Rows[e.RowIndex].Cells[i].Style.BackColor = Color.LightCyan;
        //    //    }
        //    //    dataGridView1.Rows[e.RowIndex].Cells[2].ReadOnly = true;
        //    //    //row.DefaultCellStyle.BackColor = Color.Tomato;

        //    //}
        //    //else if (dataGridView1.CurrentCell.ColumnIndex == 2 && checklist == true)
        //    //{
        //    //    MessageBox.Show("수정모드가 종료되었습니다.");
        //    //    KIS_Service service = new KIS_Service();
        //    //    checklist = false;
        //    //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //    //    {
        //    //        dataGridView1.Rows[e.RowIndex].Cells[i].ReadOnly = true;

        //    //    }

        //    //    ITEM_VO item = new ITEM_VO();
        //    //    item.ITEM_No = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        //    //    item.ITEM_Name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        //    //    item.ITEM_Code = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        //    //    item.ITEM_Size = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        //    //    item.ITEM_Unit = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        //    //    item.ITEM_Type = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        //    //    item.ITEM_ImportIns = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        //    //    item.ITEM_ProcessIns = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        //    //    item.ITEM_ShipmentIns = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        //    //    item.ITEM_OrderComp = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
        //    //    item.ITEM_InWarehouse = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
        //    //    item.ITEM_OutWarehouse = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
        //    //    item.ITEM_MinOrderQuantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString());
        //    //    item.ITEM_SafeQuantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString());
        //    //    item.ITEM_Grade = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
        //    //    item.ITEM_Manager = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
        //    //    item.ITEM_Modifier = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
        //    //    item.ITEM_ModifiyDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString());
        //    //    item.ITEM_UserOrNot = dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString();
        //    //    item.ITEM_OrderMethod = dataGridView1.Rows[e.RowIndex].Cells[21].Value.ToString();
        //    //    item.ITEM_Others = dataGridView1.Rows[e.RowIndex].Cells[22].Value.ToString();

        //    //    bool bResult = service.UpdateItem(item);
        //    //    if (bResult)
        //    //    {
        //    //        MessageBox.Show("성공적으로 수정되었습니다");
        //    //        DataLoad();
        //    //    }
        //    //    else
        //    //    {
        //    //        MessageBox.Show("수정중 오류가 발생하였습니다 다시 시도해주세요");
        //    //    }
        //    //}
        //}

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            KIS_Service service = new KIS_Service();
            List<string> list = new List<string>();
            bool check = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[1].Value) == true)
                {
                    list.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                }
            }
            if (list.Count == 0)
            {
                MessageBox.Show("삭제할 품목을 선택해 주시기 바랍니다.");
                check = false;

            }
            else if (check)
            {

                bool bResult = service.DeleteItem(string.Join(",", list));

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

        private void Button3_Click(object sender, EventArgs e)
        {
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {

        }
    }
}
