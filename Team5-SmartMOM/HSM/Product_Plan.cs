using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM.HSM
{
    public partial class Product_Plan : Team5_SmartMOM.BaseGridForm
    {
        public Product_Plan()
        {
            InitializeComponent();
        }

        private void Product_Plan_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "공정", "FACG_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "FAC_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "BOR_TactTime", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "BOR_Priority", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "BOR_UseOrNot", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "BOR_yeild", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "BOR_Ohters", true, 150);
        }
    }
}
