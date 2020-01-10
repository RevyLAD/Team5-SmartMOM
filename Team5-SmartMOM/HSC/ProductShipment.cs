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
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주문번호", "SO_WorkOrderID", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "먼가주문", "SO_PurchaseOrder", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "고객사", "COM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주문상품", "ITEM_Code", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주문일", "SO_Duedate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "뭔가수량", "SO_Qty", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주문수량", "SO_ShipQty", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "SO_Others", true, 200);

            HSC_Service service = new HSC_Service();
            service.GetAllOrder();
        }
    }
}
