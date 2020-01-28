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
    public partial class Facilities : Team5_SmartMOM.BaseGridForm
    {
        public Facilities()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FacilitiesCrowRegister frm = new FacilitiesCrowRegister();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            DataLoad();
        }

        private void panelMid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataLoad()
        {
            HSC_Service service = new HSC_Service();
            dataGridView1.DataSource = service.GetAllFacilities();
        }

        private void Facilities_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "번호", "FACG_No", true, 60);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "코드", "FACG_Code", true, 60);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "이름", "FACG_Name", true, 60);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "FACG_UseOrNot", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "FACG_Modifier", true, 70);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정일", "FACG_ModifyDate", true, 75);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설명", "FACG_Information", true, 63);

            DataLoad();
        }
    }
}
