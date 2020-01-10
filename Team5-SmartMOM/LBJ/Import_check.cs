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
    public partial class Import_check : Team5_SmartMOM.BaseGridForm
    {
        public Import_check()
        {
            InitializeComponent();
        }

        private void Import_check_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "VO_ID", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체명", "COM_Name", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "최종 결과", "VOD_Result", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납품 수량", "VOD_GoodEA", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "불량 수량", "VOD_BadEA", true, 120);
            DataLoad();
        }
        public void DataLoad()
        {
            LBJ_Service service = new LBJ_Service();
            dataGridView1.DataSource = service.Imports();
        }
    }
}

