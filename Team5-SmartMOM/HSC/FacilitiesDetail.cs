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
    public partial class FacilitiesDetail : BaseGridForm
    {
        public FacilitiesDetail()
        {
            InitializeComponent();
        }

        List<FacilitieDetailVO> list;
        private void button4_Click(object sender, EventArgs e)
        {
            FacilitiesRegister frm = new FacilitiesRegister();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void FacilitiesDetail_Load(object sender, EventArgs e)
        {
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);

            DataLoad();
        }

        private void DataLoad()
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "번호", "FAC_No", true, 70);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비군 코드", "FACG_Code", true, 105);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비 코드", "FAC_Code", true, 105);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비명", "FAC_Name", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소진창고", "FAC_OutWareHouse", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "양품창고", "FAC_InWareHouse", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "불량창고", "FAC_BadWareHouse", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "FAC_UseOrNot", true, 95);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "FAC_Modifier", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정일", "FAC_ModifiyDate", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "특이사항", "FAC_Remark", true, 60);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "FAC_Others", true, 107);

            HSC_Service service = new HSC_Service();
            dataGridView1.DataSource = list = service.GetAllFacilitiesDetail();
        }
        DataGridViewCellEventArgs temp;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = e;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FacilitiesRegister frm = new FacilitiesRegister();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
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

        private List<FacilitieDetailVO> SearchFacilities()
        {
            List<FacilitieDetailVO> newlist = new List<FacilitieDetailVO>();

            foreach (var li in list)
            {
                if (Convert.ToString(li.FAC_No).Trim().Contains(textBox1.Text.Trim()) &&
                        li.FAC_Name.Trim().Contains(textBox2.Text.Trim()))
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                if (MessageBox.Show("정말 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    HSC_Service service = new HSC_Service();
                    service.DeleteFacDetail(Convert.ToInt32(dataGridView1.Rows[temp.RowIndex].Cells[0].Value));
                }
            }
            else
            {
                MessageBox.Show("삭제할 설비를 선택해주세요");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}
