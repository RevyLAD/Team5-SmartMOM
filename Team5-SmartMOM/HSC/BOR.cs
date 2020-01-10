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
    public partial class BOR : Team5_SmartMOM.BaseGridForm
    {
        public BOR()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BORRegister frm = new BORRegister();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void DataLoad()
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "번호", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "분류", "FACG_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "클래스", "FAC_Code", true, 170);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "타입", "BOR_TactTime", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "코드", "BOR_Priority", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "공장명", "BOR_UseOrNot", true, 350);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "부모", "BOR_yeild", true, 250);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "맷", "BOR_Ohters", true, 208);

            HSC_Service service = new HSC_Service();
            dataGridView1.DataSource = service.GetAllBOR();
        }

        private void BOR_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {

        }
    }
}
