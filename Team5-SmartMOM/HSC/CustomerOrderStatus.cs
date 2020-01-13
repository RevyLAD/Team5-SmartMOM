using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM.HSC
{
    public partial class CustomerOrderStatus : Team5_SmartMOM.BaseGridForm
    {
        public CustomerOrderStatus()
        {
            InitializeComponent();
        }

        private void CustomerOrderStatus_Load(object sender, EventArgs e)
        {
                UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "SO_WorkOrderID", true, 80);
                UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "SO_PurchaseOrder", true, 160);
                UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "COM_Code", true, 130);
                UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Code", true, 130);
                UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "SO_Duedate", true, 170);
                UtilityClass.AddNewColumnToDataGridView(dataGridView1, "잔여수량", "SO_Qty", true, 160);
                UtilityClass.AddNewColumnToDataGridView(dataGridView1, "From창고", "SO_ShipQty", true, 175);
                UtilityClass.AddNewColumnToDataGridView(dataGridView1, "From창고재고", "SO_Others", true, 180);
                UtilityClass.AddNewColumnToDataGridView(dataGridView1, "To창고", "SO_Others", true, 180);
                UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "SO_Others", true, 151);
                UtilityClass.AddNewColumnToDataGridView(dataGridView1, "이동수량", "SO_Others", true, 100);
            }
    }
}
