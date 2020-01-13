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
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비군코드", "FACG_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비코드", "FAC_Code", true, 170);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "생산소요시간", "BOR_TactTime", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "우선순위", "BOR_Priority", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "BOR_UseOrNot", true, 350);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수율", "BOR_yeild", true, 250);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "BOR_Ohters", true, 208);

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
