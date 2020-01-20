using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM.HSM
{
    public partial class Meterial_Plan : Team5_SmartMOM.BaseGridForm
    {
        public Meterial_Plan()
        {
            InitializeComponent();
        }

        private void Meterial_Plan_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "FACG_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목유형", "FAC_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "창고", "BOR_TactTime", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "안전재고", "BOR_Priority", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "BOR_UseOrNot", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "BOR_yeild", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "BOR_Ohters", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "BOR_yeild", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "BOR_Ohters", true, 150);
        }
    }
}
