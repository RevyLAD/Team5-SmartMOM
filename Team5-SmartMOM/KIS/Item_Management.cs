using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM
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
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목번호", "ITEM_No", true, 40);
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Width = 40;
            chk.HeaderText = "선택";
            dataGridView1.Columns.Add(chk);
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
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "안전재고수량", "ITEM_SafeQuantity", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "관리등급", "ITEM_Grade", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "담당자", "ITEM_Manager", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "ITEM_Modifier", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정시간", "ITEM_ModifiyDate", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "ITEM_UserOrNot", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주방식", "ITEM_OrderMethod", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "ITEM_Others", true, 140);
            DataLoad();
        }
        public void DataLoad()
        {
            KIS_Service service = new KIS_Service();
            dataGridView1.DataSource = service.ShowITEM();
        }
    }
}
