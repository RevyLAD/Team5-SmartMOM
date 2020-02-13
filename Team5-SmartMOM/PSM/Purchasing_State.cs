using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5_SmartMOM.Service;
using WinReport1;

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
            dtpDateStart.Value = DateTime.Now;
            dtpDateEnd.Value = DateTime.Now.AddMonths(1);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "VO_ID", true, 70, DataGridViewContentAlignment.MiddleRight);            
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체이름", "COM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체코드", "COM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체타입", "COM_Type", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주상태", "MATERIAL_ORDER_STATE", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "단위", "ITEM_Unit", true, 80, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "VO_EndDate", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주량", "VO_Quantity", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주일", "VO_StartDate", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "입고일", "VO_InDate", true, 150, DataGridViewContentAlignment.MiddleCenter);

            DataLoad();            
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);            
        }
        #endregion

        //콤보 바인딩 및 데이터 조회
        public void DataLoad()
        {
            PurchaseSearchVO ps = new PurchaseSearchVO();
            ps.startDate = dtpDateStart.Value.ToShortDateString();
            ps.endDate = dtpDateEnd.Value.ToShortDateString();
            ps.Company = cbocompany.Text.Trim();
            ps.State = cbostate.Text.Trim();
            ps.Item = txtProduct.Text;
            ps.Plan_ID = cboplanid.Text.Trim();

            PSM_Service service = new PSM_Service();
            list = service.GetAllPurChasingState(ps);
            dataGridView1.DataSource = list;
                        

            List<CompanyCodeVO> company = service.GetAllCompanyCode();
            List<MATERIAL_ORDER_STATEVO> ORDER_STATEVO = service.GetAllOrderState();
            List<PlanIDVO> planid = service.PlanID();

            CommonUtil.ComboBinding(cbocompany, company, "COM_Code", "COM_Name", "");
            CommonUtil.ComboBinding(cbostate, ORDER_STATEVO, "MATERIAL_ORDER_STATE", "MATERIAL_ORDER_STATE", "");
            CommonUtil.ComboBinding(cboplanid, planid, "Plan_ID", "Plan_ID");
            btnSearch_Click(null, new EventArgs());
            CheckBoxTrue();   

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

        //조회버튼 클릭시 검색조건 기준으로 검색 후 텍스트박스 초기화
        private void btnSearch_Click(object sender, EventArgs e)
        {
            PurchaseSearchVO ps = new PurchaseSearchVO();
            ps.startDate = dtpDateStart.Value.ToShortDateString();
            ps.endDate = dtpDateEnd.Value.ToShortDateString();
            ps.Company = cbocompany.Text.Trim();
            ps.State = cbostate.Text.Trim();
            ps.Item = txtProduct.Text;
            ps.Plan_ID = cboplanid.Text.Trim();
            
            PSM_Service service = new PSM_Service();
            list = service.GetAllPurChasingState(ps);
            dataGridView1.DataSource = list;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[10].ReadOnly = false;
            }           

        
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
                MessageBox.Show("납기일자 변경하실 항목을 체크하세요");
                return;
            }
            
            List<EndDateChange> datelist = new List<EndDateChange>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].Value)
                {
                    EndDateChange date = new EndDateChange();
                    date.VO_ID = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    date.VO_EndDate = (DateTime)dataGridView1.Rows[i].Cells[10].Value;
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

            MessageBox.Show("발주가 취소 되었습니다.");

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

        private void button5_Click(object sender, EventArgs e)
        {
            string dtStart = dtpDateStart.Value.ToString("yyyyMMdd");
            string dtEnd = dtpDateEnd.Value.ToString("yyyyMMdd");

            string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string strSql = @"SELECT VO_ID, COM_Name, ITEM_Name, ITEM_Size, VO_Quantity, Convert(varchar(10),VO_StartDate,23) VO_StartDate
                                    FROM VendorOrder v inner join ITEM i on v.COM_Code = i.ITEM_Code
                                    WHERE VO_EndDate between '" + dtStart + "'  and '" + dtEnd + "'ORDER BY VO_ID";
                SqlDataAdapter da = new SqlDataAdapter(strSql, conn);

                da.Fill(ds, "VendorOrder");
                conn.Close();
            }

            XtraReport1 rpt = new XtraReport1();
            rpt.DataSource = ds.Tables["VendorOrder"];
            //ReportPreview frm = new ReportPreview(rpt);

            Form2 frm = new Form2();
            frm.documentViewer1.DocumentSource = rpt;
            frm.ShowDialog();
        }
    }    
}
