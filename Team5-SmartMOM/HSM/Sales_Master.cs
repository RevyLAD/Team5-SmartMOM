using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM.HSM
{
    public partial class Sales_Master : Team5_SmartMOM.BaseGridForm
    {
        public Sales_Master()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MasterCreate frm = new MasterCreate();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

        }

        private void Sales_Master_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "순번", "FACG_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "작업지시번호", "FAC_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납품처", "BOR_TactTime", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주구분", "BOR_Priority", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "BOR_UseOrNot", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수량", "BOR_yeild", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "BOR_Ohters", true, 150);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SO_Insert frm = new SO_Insert();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MPS frm = new MPS();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}
