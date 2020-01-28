using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.PSM
{
    public partial class Purchasing_Order : Form
    {
        CheckBox headerCheckBox = new CheckBox();
        CheckBox headerCheckBox2 = new CheckBox();
        List<ComPanyListVO> list;
        List<CompanyCodeVO> cbobind;
        List<CompanyCodeDetailVO> detail;
        public Purchasing_Order()
        {
            InitializeComponent();
        }

        private void Purchasing_Order_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "Check";
            chk.Width = 30;
            dataGridView1.Columns.Add(chk);

            Point headerLocation = dataGridView1.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox.Location = new Point(headerLocation.X + 8, headerLocation.Y + 2);
            headerCheckBox.BackColor = Color.White;
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += new EventHandler(HeaderCheckBox_Click);
            dataGridView1.Controls.Add(headerCheckBox);

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체번호", "COM_No", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체이름", "COM_Name", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체코드", "COM_Code", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주업체", "ITEM_OrderComp ", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주수량", "Vo_Quantity ", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "최소발주수량", "ITEM_MinOrderQuantity  ", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "Vo_EndDate", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수입검사여부", "ITEM_ImportIns ", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", false, 150);

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewCheckBoxColumn chk2 = new DataGridViewCheckBoxColumn();
            chk2.HeaderText = "";
            chk2.Name = "Check";
            chk2.Width = 30;
            dataGridView2.Columns.Add(chk2);

            Point headerLocation2 = dataGridView2.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox2.Location = new Point(headerLocation2.X + 8, headerLocation2.Y + 2);
            headerCheckBox2.BackColor = Color.White;
            headerCheckBox2.Size = new Size(18, 18);
            headerCheckBox2.Click += new EventHandler(HeaderCheckBox_Click2);
            dataGridView2.Controls.Add(headerCheckBox2);

            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "업체이름", "COM_Name", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "업체코드", "COM_Code", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목명", "ITEM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목타입", "ITEM_Type", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목사이즈", "ITEM_Size", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "대표자명", "COM_Owner", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "전화번호", "COM_Phone", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "업체정보", "COM_Information", true, 120);

            DataLoad();
            CheckBoxTrue();
        }
        public void DataLoad()
        {
            PSM_Service service = new PSM_Service();
            list = service.GetAllPurChasing();
            dataGridView1.DataSource = list;

            PSM_Service service2 = new PSM_Service();
            cbobind = service2.GetAllCompanyCode();

            List<CompanyCodeVO> company = service.GetAllCompanyCode();
            CommonUtil.ComboBinding(cbocompany, company, "COM_Code", "COM_Name", "전체");

        }

        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox.Checked;
            }
        }

        private void HeaderCheckBox_Click2(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox2.Checked;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbocompany.Text != "")
                {
                    string query = cbocompany.Text;

                    if (query == "전체")
                    {
                        dataGridView1.DataSource = list;
                    }
                    else
                    {
                        List<ComPanyListVO> searchlist = null;
                        searchlist = (from team5 in list
                                      where team5.COM_Name.ToString().Contains(query)
                                      select team5).ToList();


                        dataGridView1.DataSource = searchlist;
                    }
                }
                else
                {
                    DataLoad();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtPartNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13))
            {
                btnSearch_Click(null, new EventArgs());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtPartNo.Text.Length < 1)
            {
                MessageBox.Show("검색할 항목을 입력해주십시오.");
                return;
            }
            if (txtPartNo.Text.Trim().Length > 0)
            {
                string query = txtPartNo.Text.Trim();
                List<ComPanyListVO> searchlist = null;
                searchlist = (from team5 in list
                              where team5.COM_No.Contains(query)
                              select team5).ToList();

                dataGridView1.DataSource = searchlist;
            }
            else
            {
                DataLoad();
            }
        }

        private void CheckBoxTrue()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
            }
        }
        private void CheckBoxTrue2()
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = false;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            PSM_Service service = new PSM_Service();
            detail = new List<CompanyCodeDetailVO>();

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if ((bool)item.Cells[0].Value)
                    detail.AddRange(service.GetAllCompanyDetail(item.Cells[1].Value.ToString()));
            }

            dataGridView2.DataSource = detail;
            CheckBoxTrue2();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            List<CompanyCodeDetailVO> lists = new List<CompanyCodeDetailVO>();

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (!(bool)dataGridView2.Rows[i].Cells[0].Value)
                {
                    CompanyCodeDetailVO list = new CompanyCodeDetailVO();
                    list.COM_Name = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    list.COM_Code = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    list.ITEM_Name = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    list.ITEM_Type = dataGridView2.Rows[i].Cells[4].Value.ToString();
                    list.ITEM_Size = dataGridView2.Rows[i].Cells[5].Value.ToString();
                    list.COM_Owner = dataGridView2.Rows[i].Cells[6].Value.ToString();
                    list.COM_Phone = dataGridView2.Rows[i].Cells[7].Value.ToString();
                    list.COM_Information = dataGridView2.Rows[i].Cells[8].Value.ToString();

                    lists.Add(list);
                }
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = lists;
            CheckBoxTrue2();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            bool bFlag = false;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if ((bool)dataGridView2.Rows[i].Cells[0].Value)
                {
                    bFlag = true;
                    break;
                }
            }
            if(bFlag == false)
            {
                MessageBox.Show("발주하실 항목을 체크하세요");
                return;
            }
            List<CodeVO> codelist = new List<CodeVO>();
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if ((bool)dataGridView2.Rows[i].Cells[0].Value)
                {
                    CodeVO code = new CodeVO();
                    code.COM_Code = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    codelist.Add(code);
                }
            }
            PSM_Service service = new PSM_Service();
            service.VendorOrder(codelist);

            MessageBox.Show("발주처리가 완료 되었습니다.");
            dataGridView2.DataSource = null;

        }
    }
}


