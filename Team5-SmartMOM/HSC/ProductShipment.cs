using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.HSC
{
    public partial class ProductShipment : Team5_SmartMOM.BaseGridForm
    {
        public ProductShipment()
        {
            InitializeComponent();
        }

        private void ProductShipment_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "작업지시서 번호", "SO_WorkOrderID", true, 250);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "고객주문번호", "SO_PurchaseOrder", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "고객사", "COM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "SO_Duedate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주문수량", "SO_Qty", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "출고수량", "SO_ShipQty", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "SO_Others", true, 200);

            HSC_Service service = new HSC_Service();
            service.GetAllOrder();
        }
    }
}
