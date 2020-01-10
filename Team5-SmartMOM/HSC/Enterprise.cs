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
    public partial class Enterprise : Team5_SmartMOM.BaseGridForm
    {
        public Enterprise()
        {
            InitializeComponent();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnterpriseRegister frm = new EnterpriseRegister();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void Enterprise_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "번호", "COM_No", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "코드", "COM_Code", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "이름", "COM_Name", true, 110);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "타입", "COM_Type", true, 110);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "오너", "COM_Owner", true, 110);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "섹터", "COM_Sector", true, 110);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "관리자", "COM_Manager", true, 110);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "E-mail", "COM_Email", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "연락처", "COM_Phone", true, 130);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "COM_UseOrNot", true, 130);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "모디", "COM_Modifier", true, 110);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "모디일", "COM_ModifiyDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설명", "COM_Information", true, 257);

            HSC_Service service = new HSC_Service();
            dataGridView1.DataSource = service.GetAllEnterprise();
        }
    }
}
