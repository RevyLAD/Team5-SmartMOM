using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM.HSC
{
    public partial class ShipmentStatus : Team5_SmartMOM.BaseGridForm
    {
        public ShipmentStatus()
        {
            InitializeComponent();
        }

        private void ShipmentStatus_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "SO_WorkOrderID", true, 60);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "고객주문번호", "SO_PurchaseOrder", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "PO NO", "COM_Code", true, 110);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "출발번호", "ITEM_Code", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "고객사명", "SO_Duedate", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "도착지명", "SO_Qty", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "고객품목", "SO_ShipQty", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "SO_Others", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "SO_Others", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일자", "SO_Others", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "출하일자", "SO_Others", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주문수량", "SO_Others", true, 100); 
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "총출하수량", "SO_Others", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "출하수량", "SO_Others", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "취소수량", "SO_Others", true, 100);
        }
    }
}
