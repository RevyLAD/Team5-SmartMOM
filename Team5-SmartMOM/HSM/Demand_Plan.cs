using Project_VO;
using Project_VO.HSM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.BaseForm;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.HSM
{
    public partial class Demand_Plan : Team5_SmartMOM.BaseGridForm
    {
        public Demand_Plan()
        {
            InitializeComponent();
        }

        private void Demand_Plan_Load(object sender, EventArgs e)
        {
            dtpDateEnd.Value = DateTime.Now.AddMonths(1);
            InitCombo();
            btnSearch.PerformClick();

        }

        private void InitCombo() //콥보박스 바인딩
        {
            CommonCodeService service = new CommonCodeService();

            List<PlanIDVO> listPlanID = service.GetAllPlanID();
            List<CompanyCodeVO> listCompanyCode = service.GetAllCompanyCode();
            List<ItemCodeVO> listItemCode = service.GetAllItemCode();



            CommonUtil.ComboBinding(cboPlanID, listPlanID, "Plan_ID", "Plan_ID","전체");
            CommonUtil.ComboBinding(cboCompany, listCompanyCode, "COM_Code", "COM_Name","");
            CommonUtil.ComboBinding(cboProduct, listItemCode, "ITEM_Code", "ITEM_Name","");

        }

        private void btnSearch_Click(object sender, EventArgs e) //조회버튼
        {

            PlanningVO plan = new PlanningVO();
            HSM_Service service = new HSM_Service();

            plan.PlanId = cboPlanID.Text;
            plan.SALES_OrderDate = dtpDateStart.Value.ToShortDateString();
            plan.SALES_DueDate = dtpDateEnd.Value.ToShortDateString();
            plan.ITEM_Code = cboProduct.Text;
            plan.COM_Code = cboCompany.Text;

            if(cboPlanID.Text == "전체")
            {

                DataSet ds = service.GetAllDemandPlan(plan);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {

                DataSet ds = service.GetAllDemandPlanByPlanID(plan);
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateStart.Value > dtpDateEnd.Value.AddDays(1))
            {
                MessageBox.Show("시작일보다 빠를 수 없습니다.");
                dtpDateEnd.Value = dtpDateStart.Value.AddMonths(1);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e) //생산계획 생성
        {
            HSM_Service service = new HSM_Service();
            
            if(dataGridView1.Rows.Count>0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string workId = row.Cells[0].Value.ToString();
                    service.UpdatePlanID(workId);

                    if(!service.UpdatePlanID(workId))
                    {
                        MessageBox.Show("저장실패");
                        return;
                    }
                }
                MessageBox.Show("생산계획 생성 완료");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show("조회후 생산계획을 생성하세요", "확인");
            }
        }

        private void cboPlanID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(cboPlanID.Text.ToString() == "전체"))
            {
                string[] arrDate = cboPlanID.Text.Split('_');
                DateTime.ParseExact(arrDate[0], "yyyyMMdd", null).ToString("yyyy-MM-dd");
            }
        }
    }
}
