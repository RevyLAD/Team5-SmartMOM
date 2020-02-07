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
using Team5_SmartMOM.BaseForm;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.PSM
{
    public partial class Supplier : Form
    {
        List<SupplierVO> list;
        List<SupplierStateVO> list2;
        List<CompanyCodeVO> company;
        CheckBox headerCheckBox = new CheckBox();
        CheckBox headerCheckBox2 = new CheckBox();
        public Supplier()
        {
            InitializeComponent();
        }

        //데이터그리드뷰 체크박스 및 데이터그리드뷰 컬럼띄우기
        private void Supplier_Load(object sender, EventArgs e)
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

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주번호", "VO_ID", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주일자", "VO_StartDate", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주업체", "ITEM_OrderComp", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체코드", "COM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납품업체", "COM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "단위", "ITEM_Unit", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "검사여부", "ITEM_ImportIns", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주량", "VO_Quantity", true, 150);                        
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일자", "VO_EndDate", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주유형", "ITEM_OrderMethod", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주상태", "MATERIAL_ORDER_STATE", true, 150);

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

            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "발주번호", "VO_ID", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "업체이름", "COM_Name", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "업체타입", "COM_Type", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "업체코드", "COM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목이름", "ITEM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "발주상태", "MATERIAL_ORDER_STATE", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "발주량", "VO_Quantity", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "잔여량", "FACD_Qty", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "단위", "ITEM_Unit", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "규격", "ITEM_Size", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목코드", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "납기일자", "VO_EndDate", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "발주일자", "VO_StartDate", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "", "VO_InDate", false, 150);

            DataLoad();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
        }        

        //콤보바인딩 및 데이터조회
        public void DataLoad()
        {
            PSM_Service service = new PSM_Service();
            list = service.Supplier();
            dataGridView1.DataSource = list;

            PSM_Service service2 = new PSM_Service();
            list2 = service2.SupplierState();
            dataGridView2.DataSource = list2;

            CommonCodeService common = new CommonCodeService();
            company = common.GetAllCompanyCode();
            CommonUtil.ComboBinding(cbocompany, company, "COM_Code", "COM_Name", "전체");
            
        }
        //데이터그리드뷰1 헤더체크박스
        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox.Checked;
            }
        }
        //데이터그리드뷰2 헤더체크박스
        private void HeaderCheckBox_Click2(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox2.Checked;
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
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool isChecked = true;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue) == false)
                    {
                        isChecked = false;
                        break;
                    }
                }
                headerCheckBox2.Checked = isChecked;
            }
        }

        //데이트타임피커 기준
        private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateStart.Value > dtpDateEnd.Value.AddDays(1))
            {
                MessageBox.Show("시작일보다 빠를 수 없습니다.");
                dtpDateEnd.Value = dtpDateStart.Value.AddMonths(1);
                return;
            }
        }

        //조회버튼시 검색
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtProduct.Text.Length < 1 && txtOrderNum.Text.Length < 1)
            {
                MessageBox.Show("검색할 항목을 입력해주십시오.");
                return;
            }
            else if (txtProduct.Text.Trim().Length > 0)
            {
                string query = txtProduct.Text.Trim();
                List<SupplierVO> searchlist = null;
                searchlist = (from team5 in list
                              where team5.ITEM_Name.Contains(query)
                              select team5).ToList();

                dataGridView1.DataSource = searchlist;
            }
            else if (txtOrderNum.Text.Trim().Length > 0)
            {
                string query = txtOrderNum.Text.Trim();
                List<SupplierVO> searchlist = null;
                searchlist = (from team5 in list
                              where team5.VO_ID.ToString().Contains(query)
                              select team5).ToList();

                dataGridView1.DataSource = searchlist;
            }

            else
            {
                DataLoad();
            }
            txtOrderNum.Text = "";
            txtProduct.Text = "";
        }

        //업체콤보박스 검색시 조회
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
                        List<SupplierVO> searchlist = null;
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
        //검색후 엔터로 조회버튼
        private void txtProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13))
            {
                btnSearch_Click(null, new EventArgs());
            }
            
        }
        //숫자만 검색가능, 검색후 엔터로 조회버튼
        private void txtOrderNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
                e.Handled = true;
            if ((e.KeyChar == 13))
            {
                btnSearch_Click(null, new EventArgs());
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
            service.OrderChange(lists);

            DataLoad();
        }

        //
        private void btnCancel_Click(object sender, EventArgs e)
        {
            List<DeleteOrder> lists = new List<DeleteOrder>();

            foreach (DataGridViewRow row in dataGridView2.Rows)
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
            service.OrderCancel(lists);

            DataLoad();
        }

        //입고대기버튼
        private void btnWait_Click(object sender, EventArgs e)
        {
            List<DeleteOrder> lists = new List<DeleteOrder>();
            List<VenderorderDetailVO> lists2 = new List<VenderorderDetailVO>();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                bool isCellChecked = Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue);

                if (isCellChecked)
                {
                    DeleteOrder list = new DeleteOrder();                    
                    list.VO_ID = Convert.ToInt32(row.Cells[1].Value);                    
                    lists.Add(list);

                    VenderorderDetailVO list2 = new VenderorderDetailVO();
                    list2.VO_ID = Convert.ToInt32(row.Cells[1].Value);
                    list2.VOD_GoodEA = Convert.ToInt32(row.Cells[7].Value);
                    list2.VO_StartDate = (DateTime)row.Cells[13].Value;
                    lists2.Add(list2);
                }
            }
            PSM_Service service = new PSM_Service();
            service.WarehousingWait(lists, lists2);

            DataLoad();
        }
    }   
    
}
