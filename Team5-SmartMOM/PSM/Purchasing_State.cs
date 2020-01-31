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
    public partial class Purchasing_State : BaseGridForm
    {
        CheckBox headerCheckBox = new CheckBox();
        DataGridViewCheckBoxColumn chk;
        List<PurchasingStateVO> list;
        public Purchasing_State()
        {
            InitializeComponent();
        }


        #region 데이터그리드뷰 체크박스 및 데이터그리드뷰 컬럼띄우기
        private void Purchasing_State_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            chk = new DataGridViewCheckBoxColumn();
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

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주번호", "VO_ID", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체번호", "COM_No", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체이름", "COM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체코드", "COM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체타입", "COM_Type", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주상태", "MATERIAL_ORDER_STATE", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "단위", "ITEM_Unit", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "VO_EndDate", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주량", "VO_Quantity", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주일", "VO_StartDate", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "입고일", "VO_InDate", true, 150);

            DataLoad();            
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);            
        }
        #endregion

        //콤보 바인딩 및 데이터 조회
        public void DataLoad()
        {
            PSM_Service service = new PSM_Service();
            list = service.GetAllPurChasingState();
            dataGridView1.DataSource = list;

            List<CompanyCodeVO> company = service.GetAllCompanyCode();
            List<MATERIAL_ORDER_STATEVO> ORDER_STATEVO = service.GetAllOrderState();

            CommonUtil.ComboBinding(cbocompany, company, "COM_Code", "COM_Name", "전체");
            CommonUtil.ComboBinding(cbostate, ORDER_STATEVO, "MATERIAL_ORDER_STATE", "MATERIAL_ORDER_STATE", "전체");
            
            CheckBoxTrue();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[11].ReadOnly = false;
            }



        }
        //데이터그리드뷰 헤더체크박스 
        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox.Checked;
            }
        }
        //데이트타임피커 기준정보
        private void DtpDateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateStart.Value > dtpDateEnd.Value.AddDays(1))
            {
                MessageBox.Show("시작일보다 빠를 수 없습니다.");
                dtpDateEnd.Value = dtpDateStart.Value.AddMonths(1);
                return;
            }
        }

        //업체정보 콤보박스 검색
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
                        List<PurchasingStateVO> searchlist = null;
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
    
        //발주상태 콤보박스 검색
        private void cbostate_SelectedIndexChanged(object sender, EventArgs e)
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
                        List<PurchasingStateVO> searchlist = null;
                        searchlist = (from team5 in list
                                      where team5.MATERIAL_ORDER_STATE.ToString().Contains(query)
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

        //조회버튼 클릭시 검색조건 기준으로 검색 후 텍스트박스 초기화
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtProduct.Text.Length < 1 && txtVoID.Text.Length < 1)
            {
                MessageBox.Show("검색할 항목을 입력해주십시오.");
                return;
            }
            else if (txtProduct.Text.Trim().Length > 0)
            {
                string query = txtProduct.Text.Trim();
                List<PurchasingStateVO> searchlist = null;
                searchlist = (from team5 in list
                              where team5.ITEM_Name.Contains(query)
                              select team5).ToList();

                dataGridView1.DataSource = searchlist;
            }
            else if (txtVoID.Text.Trim().Length > 0)
            {
                string query = txtVoID.Text.Trim();
                List<PurchasingStateVO> searchlist = null;
                searchlist = (from team5 in list
                              where team5.VO_ID.ToString().Contains(query)
                              select team5).ToList();

                dataGridView1.DataSource = searchlist;
            }

            else
            {
                DataLoad();
            }
            txtProduct.Text = "";
            txtVoID.Text = "";
        }

        //체크된 항목만 납기일자 변경
        private void button3_Click(object sender, EventArgs e)
        {
            
            bool bFlag = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].Value)
                {
                    bFlag = true;
                    break;
                }
            }
            if (bFlag == false)
            {
                MessageBox.Show("발주하실 항목을 체크하세요");
                return;
            }
            
            List<EndDateChange> datelist = new List<EndDateChange>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].Value)
                {
                    EndDateChange date = new EndDateChange();
                    date.VO_ID = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    date.VO_EndDate = (DateTime)dataGridView1.Rows[i].Cells[11].Value;
                    datelist.Add(date);
                }
            }
            PSM_Service service = new PSM_Service();
            service.EndDateChange(datelist);

            MessageBox.Show("납기일자가 변경되었습니다.");

            DataLoad();

        }
        
        //체크된 항목만 발주 취소기능
        private void button2_Click(object sender, EventArgs e)
        {
            bool bFlag = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].Value)
                {
                    bFlag = true;
                    break;
                }
            }
            if (bFlag == false)
            {
                MessageBox.Show("삭제하실 항목을 체크하세요");
                return;
            }
            List<DeleteOrder> deletelist = new List<DeleteOrder>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].Value)
                {
                    DeleteOrder delete = new DeleteOrder();
                    delete.VO_ID = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    deletelist.Add(delete);
                }
            }
            PSM_Service service = new PSM_Service();
            service.OrderDelete(deletelist);

            MessageBox.Show("발주삭제가 완료 되었습니다.");

            DataLoad();
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

        private void CheckBoxTrue()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
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

        //숫자로만 입력 및 검색후 엔터로 조회버튼
        private void txtVoID_KeyPress(object sender, KeyPressEventArgs e)
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
