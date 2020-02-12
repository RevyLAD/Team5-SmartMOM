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

namespace Team5_SmartMOM.PSM
{
    public partial class Material_Ledger_State : Team5_SmartMOM.BaseGridForm
    {
        List<CompanyCodeVO> company;
        CheckBox headerCheckBox = new CheckBox();
        DataGridViewCheckBoxColumn chk;
        List<MaterialsStateVO> list = new List<MaterialsStateVO>();
        public Material_Ledger_State()
        {
            InitializeComponent();
        }

        private void Material_Ledger_State_Load(object sender, EventArgs e)
        {
            dtpDateStart.Value = DateTime.Now;
            dtpDateEnd.Value = DateTime.Now.AddMonths(1);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "Check";
            chk.Width = 30;
            dataGridView1.Columns.Add(chk);

            Point headerLocation = dataGridView1.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox.Location = new Point(headerLocation.X + 8, headerLocation.Y + 6);
            headerCheckBox.BackColor = Color.FromArgb(55, 113, 138);
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += new EventHandler(HeaderCheckBox_Click);
            dataGridView1.Controls.Add(headerCheckBox);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "VO_ID", true, 70, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "입고일", "VO_InDate", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "예외입고유형", "", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "입고창고", "FACT_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "단위", "ITEM_Unit", true, 80, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "입고량", "VOD_GoodEA", true, 120, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "잔량", "FACD_Qty", true, 150, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체", "COM_Name", true, 100);
            

            DataLoad();
        }

        public void DataLoad()
        {
            SupplierSearchVO sp = new SupplierSearchVO();
            sp.startDate = dtpDateStart.Value.ToShortDateString();
            sp.endDate = dtpDateEnd.Value.ToShortDateString();
            sp.Company = cbocompany.Text.Trim();
            sp.Item = txtProduct.Text.Trim();
           

            PSM_Service service = new PSM_Service();
            list = service.MaterialsState(sp);
            dataGridView1.DataSource = list;

            CommonCodeService common = new CommonCodeService();
            company = common.GetAllCompanyCode();
            CommonUtil.ComboBinding(cbocompany, company, "COM_Code", "COM_Name", "");
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

        private void button2_Click(object sender, EventArgs e)
        {
            bool bFlag = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells["Check"].EditedFormattedValue)
                {
                    bFlag = true;
                    break;
                }
            }
            if (bFlag == false)
            {
                MessageBox.Show("취소하실 항목을 선택해주세요.");
                return;
            }
            if (MessageBox.Show("선택하신 항목의 입고를 취소하시겠습니까?", "입고취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<DeleteOrder> lists = new List<DeleteOrder>();
                List<MaterialsPlusVO> lists2 = new List<MaterialsPlusVO>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    bool isCellChecked = Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue);

                    if (isCellChecked)
                    {
                        DeleteOrder list = new DeleteOrder();
                        list.VO_ID = Convert.ToInt32(row.Cells[1].Value);
                        lists.Add(list);

                        MaterialsPlusVO list2 = new MaterialsPlusVO();
                        list2.VOD_GoodEA = Convert.ToInt32(row.Cells[9].Value);
                        list2.ITEM_Code = row.Cells[5].Value.ToString();
                        lists2.Add(list2);
                    }
                }
                PSM_Service service = new PSM_Service();
                service.MaterialCancel(lists, lists2);

                DataLoad();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SupplierSearchVO sp = new SupplierSearchVO();
            sp.startDate = dtpDateStart.Value.ToShortDateString();
            sp.endDate = dtpDateEnd.Value.ToShortDateString();
            sp.Company = cbocompany.Text.Trim();
            sp.Item = txtProduct.Text.Trim();            

            PSM_Service service = new PSM_Service();
            list = service.MaterialsState(sp);
            dataGridView1.DataSource = list;
        }

        private void txtProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13))
            {
                BtnSearch_Click(null, new EventArgs());
            }
        }
    }
}
