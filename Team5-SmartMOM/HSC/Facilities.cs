using Project_VO;
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

        List<FacilitieVO> list;

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
            dataGridView1.DataSource = list = service.GetAllFacilities();

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Trim() == "") && (textBox2.Text.Trim() == ""))
            {
                MessageBox.Show("검색어를 입력해주세요");
            }
            else
            {
                dataGridView1.DataSource = SearchFacilities();
            }
        }

        private List<FacilitieVO> SearchFacilities()
        {
            List<FacilitieVO> newlist = new List<FacilitieVO>();

            foreach (var li in list)
            {
                if (Convert.ToString(li.FACG_No).Trim().Contains(textBox1.Text.Trim()) &&
                        li.FACG_Name.Trim().Contains(textBox2.Text.Trim()))
                            newlist.Add(li);
            }
            return newlist;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }
    }
}
