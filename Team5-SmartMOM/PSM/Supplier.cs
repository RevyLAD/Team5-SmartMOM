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
        List<CompanyCodeVO> company;
        CheckBox headerCheckBox = new CheckBox();
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
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납품업체", "COM_Code", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납품업체", "COM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "단위", "ITEM_Unit", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "검사여부", "ITEM_ImportIns", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주량", "VO_Quantity", true, 150);                        
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일자", "VO_EndDate", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주유형", "ITEM_OrderMethod", true, 150);

            dataGridView2.Columns.Add("발주시리얼", "발주시리얼");            
            dataGridView2.Columns.Add("품목", "품목");
            dataGridView2.Columns.Add("품명", "품명");
            dataGridView2.Columns.Add("규격", "규격");
            dataGridView2.Columns.Add("단위", "단위");
            dataGridView2.Columns.Add("발주수량", "발주수량");
            dataGridView2.Columns.Add("잔여수량", "잔여수량");
            dataGridView2.Columns.Add("입고수량", "입고수량");
            dataGridView2.Columns.Add("발주유형", "발주유형");
            dataGridView2.Columns.Add("입고일자", "입고일자");
            dataGridView2.Columns.Add("발주일자", "발주일자");
            dataGridView2.Columns.Add("검사유무", "검사유무");
            dataGridView2.Columns.Add("비고", "비고");

            DataLoad();
        }        

        //콤보바인딩 및 데이터조회
        public void DataLoad()
        {
            PSM_Service service = new PSM_Service();
            list = service.Supplier();
            dataGridView1.DataSource = list;


            CommonCodeService common = new CommonCodeService();
            company = common.GetAllCompanyCode();
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
    }
    
    
}
