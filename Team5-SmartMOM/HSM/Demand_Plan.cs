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

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "고객WO", "SO_WorkOrderID", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "고객사코드", "COM_Code", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "고객사명", "COM_Name", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "SALES_DueDate", true, 100);


            dtpDateEnd.Value = DateTime.Now.AddMonths(1);
            InitCombo();


        }

        private void InitCombo()
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
    }
}
