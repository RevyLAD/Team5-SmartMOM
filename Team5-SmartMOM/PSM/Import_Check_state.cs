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
    public partial class Import_Check_state : Form
    {
        List<ImportCheckVO> list = new List<ImportCheckVO>();
        CheckBox headerCheckBox = new CheckBox();
        public Import_Check_state()
        {
            InitializeComponent();
        }

        private void Import_Check_state_Load(object sender, EventArgs e)
        {
            dtpDateStart.Value = DateTime.Now;
            dtpDateEnd.Value = DateTime.Now.AddMonths(1);
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "Check";
            chk.Width = 30;
            dataGridView1.Columns.Add(chk);

            Point headerLocation = dataGridView1.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox.Location = new Point(headerLocation.X + 8, headerLocation.Y + 6);
            headerCheckBox.BackColor = Color.White;
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += new EventHandler(HeaderCheckBox_Click);
            dataGridView1.Controls.Add(headerCheckBox);


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "출발번호", "VO_ID", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "검사일", "VOD_ResultDay", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체명", "COM_Name", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "최종결과", "VOD_Result", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납품수량", "VOD_GoodEA", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "불량수량", "VOD_BadEA", true, 150);

            cboResult.Items.Add("전체");
            cboResult.Items.Add("합격");
            cboResult.Items.Add("불합격");
            DataLoad();
            Datagridview();
        }

        public void Datagridview()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 113, 138);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        }

            public void DataLoad()
        {
            PSM_Service service = new PSM_Service();
            list = service.ImportCheck();
            dataGridView1.DataSource = list;
            
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool isChecked = true;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue) == false)
                    {
                        isChecked = false;
                        break;
                    }
                }
                headerCheckBox.Checked = isChecked;
            }
        }

        private void btnCheck_OK_Click(object sender, EventArgs e)
        {
            List<DeleteOrder> lists = new List<DeleteOrder>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isCellChecked = Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue);

                if (isCellChecked)
                {
                    DeleteOrder list = new DeleteOrder();
                    list.VO_ID = Convert.ToInt32(row.Cells[1].Value);
                    lists.Add(list);
                }
            }
            PSM_Service service = new PSM_Service();
            service.Result(lists);

            DataLoad();
        }

        private void DtpDateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateStart.Value > dtpDateEnd.Value.AddDays(1))
            {
                MessageBox.Show("시작일보다 빠를 수 없습니다.");
                dtpDateEnd.Value = dtpDateStart.Value.AddMonths(1);
                return;
            }
        }

        private void cbocompany_SelectedIndexChanged(object sender, EventArgs e)
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
                        List<ImportCheckVO> searchlist = null;
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

        private void cboResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboResult.Text != "")
                {
                    string query = cboResult.Text;

                    if (query == "전체")
                    {
                        dataGridView1.DataSource = list;
                    }
                    else
                    {
                        List<ImportCheckVO> searchlist = null;
                        searchlist = (from team5 in list
                                      where team5.VOD_Result.ToString().Contains(query)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtitem.Text.Length < 1)
            {
                MessageBox.Show("검색할 항목을 입력해주십시오.");
                DataLoad();
                return;
            }
            if (txtitem.Text.Trim().Length > 0)
            {
                string query = txtitem.Text.Trim();
                List<ImportCheckVO> searchlist = null;
                searchlist = (from team5 in list
                              where team5.ITEM_Name.Contains(query)
                              select team5).ToList();

                dataGridView1.DataSource = searchlist;
            }
            else
            {
                DataLoad();
            }
        }

        private void txtitem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13))
            {
                btnSearch_Click(null, new EventArgs());
            }
        }
    }
    
}
