using Project_VO;
using Project_VO.HSM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.BaseForm;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.HSM
{
    public partial class Product_Plan : Team5_SmartMOM.BaseGridForm
    {
        public Product_Plan()
        {
            InitializeComponent();
        }

        private void Product_Plan_Load(object sender, EventArgs e)
        {

            dtpDateEnd.Value = DateTime.Now.AddMonths(1);
            InitCombo();
            btnSearch.PerformClick();
        }


        private void InitCombo() //콥보박스 바인딩
        {
            CommonCodeService service = new CommonCodeService();

            List<PlanIDVO> listPlanID = service.GetAllPlanID();
            List<ItemCodeVO> listItemCode = service.GetAllItemCode();



            CommonUtil.ComboBinding(cboPlanID, listPlanID, "Plan_ID", "Plan_ID");
            CommonUtil.ComboBinding(cboProduct, listItemCode, "ITEM_Code", "ITEM_Name", "");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PlanningVO plan = new PlanningVO();
            HSM_Service service = new HSM_Service();

            plan.PlanId = cboPlanID.Text;
            plan.SALES_OrderDate = dtpDateStart.Value.ToShortDateString();
            plan.SALES_DueDate = dtpDateEnd.Value.ToShortDateString();


            DataSet ds = service.GetProductPlan(plan);
            dataGridView1.DataSource = ds.Tables[0];
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

        private void dtpDateStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateStart.Value > dtpDateEnd.Value)
            {
                MessageBox.Show("종료일보다 늦을 수 없습니다.");
                dtpDateStart.Value = dtpDateEnd.Value.AddMonths(-1);
                return;
            }
        }
    }
}
