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
    public partial class EnterPriseMain : Team5_SmartMOM.BaseGridForm
    {
        public EnterPriseMain()
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
            DataLoad();
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
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "대표자명", "COM_Owner", true, 125);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업종", "COM_Sector", true, 110);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "관리자", "COM_Manager", true, 110);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "E-mail", "COM_Email", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "연락처", "COM_Phone", true, 130);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "COM_UseOrNot", true, 130);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "COM_Modifier", true, 110);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정일", "COM_ModifiyDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설명", "COM_Information", true, 257);

            HSC_Service service = new HSC_Service();
            dataGridView1.DataSource = service.GetAllEnterprise();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            BORSearch(textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim(), cboFacCrow.Text.Trim());
        }

        private void BORSearch(string code, string name, string no, string type)
        {
            DataGridView dgv = new DataGridView();

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[0].Value.ToString() == no &&
                    item.Cells[1].Value.ToString() == code &&
                    item.Cells[2].Value.ToString() == name &&
                    item.Cells[3].Value.ToString() == code)
                    dgv.Rows.Add(item);
            }
            dataGridView1.DataSource = dgv;
        }
    }
}
