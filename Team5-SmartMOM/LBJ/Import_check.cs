using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.LBJ
{
    public partial class Import_Check : Team5_SmartMOM.BaseGridForm
    {
        public Import_Check()
        {
            InitializeComponent();
        }
        private void Import_Check_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "VO_ID", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체명", "COM_Name", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "최종 결과", "VOD_Result", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납품 수량", "VOD_GoodEA", true, 165);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "불량 수량", "VOD_BadEA", true, 165);

            DataLoad();
        }
        public void DataLoad()
        {
            LBJ_Service service = new LBJ_Service();
            dataGridView1.DataSource = service.Imports();
        }
    }
}
