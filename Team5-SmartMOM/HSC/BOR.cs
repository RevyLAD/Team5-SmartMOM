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
    public partial class BOR : Team5_SmartMOM.BaseGridForm
    {
        public BOR()
        {
            InitializeComponent();
        }

        List<BORVO> list;
        private void button3_Click(object sender, EventArgs e)
        {
            BORRegister frm = new BORRegister(1);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            DataLoad();
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
            dataGridView1.DataSource = list = service.GetAllBOR();
        }

        private void BOR_Load(object sender, EventArgs e)
        {
            DataLoad();

            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()==""&& 
                textBox2.Text.Trim()==""&&
                cboFacCrow.Text.Trim()=="")
            {
                MessageBox.Show("검색어를 입력해주세요");
            }
            else
            {
                dataGridView1.DataSource = SearchBOR();
            }
        }

        private List<BORVO> SearchBOR()
        {
            List<BORVO> newlist = new List<BORVO>();

            foreach (var li in list)
            {
                if (Convert.ToString(li.ITEM_Code).Trim().Contains(textBox1.Text.Trim())&&
                        li.FAC_Code.Trim().Contains(textBox2.Text.Trim())&&
                        li.FACG_Code.Trim().Contains(cboFacCrow.Text.Trim()))
                    newlist.Add(li);
            }

            return newlist;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BORRegister frm = new BORRegister(2);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        DataGridViewCellEventArgs temp;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = e;
        }

    }
}
