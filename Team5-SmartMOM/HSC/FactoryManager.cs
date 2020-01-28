using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.HSC
{
    public partial class FactoryManager : Team5_SmartMOM.BaseGridForm
    {
        public FactoryManager()
        {
            InitializeComponent();
        }

        List<FactoryVO> list;
        FactoryVO select_vo;

        private void FactoryManager_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "번호", "FACT_No", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시설군", "FACT_Group", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시설구분", "FACT_Class", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "타입", "FACT_Type", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "코드", "FACT_Code", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "공장명", "FACT_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "상위시설", "FACT_Parent", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "자재차감", "FACT_MATDeduction", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "FACT_UseOrNot", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "FACT_Modifier", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정일", "FACT_ModifyDate", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설명", "FACT_Information", true, 258);

            Factory_DataLoad();
        }


        private void Factory_DataLoad()
        {
            HSC_Service service = new HSC_Service();
            dataGridView1.DataSource = list  = service.GetAllFactory();


            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            FactoryRegister frm = new FactoryRegister();
            frm.StartPosition = FormStartPosition.CenterParent;
            if(frm.ShowDialog() != DialogResult.Cancel)
            {
                Factory_DataLoad();
            }
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            List<FactoryVO> newlist = new List<FactoryVO>();

            if ((textBox1.Text.Trim() == "") && (textBox2.Text.Trim() == ""))
            {
                MessageBox.Show("검색어를 입력해주세요");
            }
            else
            {
                foreach (var li in list)
                {
                    if (Convert.ToString(li.FACT_Name).Trim().Contains(textBox1.Text.Trim()) &&
                        li.FACT_Code.Trim().Contains(textBox2.Text.Trim()))
                        newlist.Add(li);
                }
                dataGridView1.DataSource = newlist;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (temp is null)
            {
                MessageBox.Show("수정할 항목을 선택해주세요");
            }
            else
            {
                select_vo.FACT_No = Convert.ToInt32(dataGridView1.Rows[temp.RowIndex].Cells[0].Value.ToString());
                select_vo.FACT_Group = dataGridView1.Rows[temp.RowIndex].Cells[1].Value.ToString();
                select_vo.FACT_Class = dataGridView1.Rows[temp.RowIndex].Cells[2].Value.ToString();
                select_vo.FACT_Type = dataGridView1.Rows[temp.RowIndex].Cells[3].Value.ToString();
                select_vo.FACT_Code = dataGridView1.Rows[temp.RowIndex].Cells[4].Value.ToString();
                select_vo.FACT_Name = dataGridView1.Rows[temp.RowIndex].Cells[5].Value.ToString();
                select_vo.FACT_Parent = dataGridView1.Rows[temp.RowIndex].Cells[6].Value.ToString();
                select_vo.FACT_MATDeducation = dataGridView1.Rows[temp.RowIndex].Cells[7].Value.ToString();
                select_vo.FACT_UseOrNot = dataGridView1.Rows[temp.RowIndex].Cells[8].Value.ToString();
                select_vo.FACT_Modifier = dataGridView1.Rows[temp.RowIndex].Cells[9].Value.ToString();
                //select_vo.FACT_ModifyDate = dataGridView1.Rows[temp.RowIndex].Cells[10].Value.ToString();
                select_vo.FACT_Information = dataGridView1.Rows[temp.RowIndex].Cells[11].Value.ToString();

                FactoryRegister frm = new FactoryRegister(select_vo);
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() != DialogResult.Cancel)
                {

                }
            }
        }
        DataGridViewCellEventArgs temp;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = e;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInquiry_Click(this, new EventArgs());
            }
        }
    }
}
