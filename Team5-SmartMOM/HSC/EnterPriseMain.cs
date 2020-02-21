using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.BaseForm;
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

            CommonCodeService cmservice = new CommonCodeService();
            CommonUtil.ComboBinding(cboFacCrow, cmservice.GetFacilityType(), "Common_Key", "Common_Value");
        }
        List<EnterpriseVO> list;

        private void DataLoad()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "번호", "COM_No", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "코드", "COM_Code", true, 130);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "이름", "COM_Name", true, 130);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "타입", "COM_Type", true, 110, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "대표자명", "COM_Owner", true, 125, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업종", "COM_Sector", true, 110, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "관리자", "COM_Manager", true, 110, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "E-mail", "COM_Email", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "연락처", "COM_Phone", true, 130, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "COM_UseOrNot", true, 130, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "COM_Modifier", true, 110, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정일", "COM_ModifiyDate", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설명", "COM_Information", true, 180);

            HSC_Service service = new HSC_Service();
            dataGridView1.DataSource = list = service.GetAllEnterprise();

            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);

        }
        DataGridViewCellEventArgs temp;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = e;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" &&
                textBox2.Text.Trim() == "" &&
                cboFacCrow.Text.Trim() == "")
            {
                MessageBox.Show("검색어를 입력해주세요");
            }
            else
            {
                dataGridView1.DataSource = SearchEnterPrise();
            }
        }

        private List<EnterpriseVO> SearchEnterPrise()
        {
            List<EnterpriseVO> newlist = new List<EnterpriseVO>();

            foreach (var li in list)
            {
                if (Convert.ToString(li.COM_No).Trim().Contains(textBox1.Text.Trim()) &&
                        li.COM_Name.Trim().Contains(textBox2.Text.Trim()) &&
                        li.COM_Type.Trim().Contains(cboFacCrow.Text.Trim()))
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
                EnterpriseVO vo = null;
                foreach(EnterpriseVO item in list)
                {
                    if (item.COM_No.Trim() == Convert.ToString(dataGridView1.Rows[temp.RowIndex].Cells[0].Value))
                    {
                        vo = item;
                        break;
                    }
                }

                EnterpriseRegister frm = new EnterpriseRegister(vo);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                DataLoad();
            }
            else
            {
                MessageBox.Show("수정할 업체를 선택해주세요");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                if (MessageBox.Show("정말 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    HSC_Service service = new HSC_Service();
                    service.DeleteEnt(Convert.ToString(dataGridView1.Rows[temp.RowIndex].Cells[0].Value));
                    DataLoad();
                }
            }
            else
            {
                MessageBox.Show("삭제한 업체를 선택해주세요");
            }
        }
    }
}
