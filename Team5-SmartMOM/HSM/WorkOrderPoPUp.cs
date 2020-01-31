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
    public partial class WorkOrderPoPUp : Team5_SmartMOM.BasePopUpDialog
    {
        public WorkOrderPoPUp()
        {
            InitializeComponent();
        }

        private void WorkOrderPoPUp_Load(object sender, EventArgs e)
        {
            InitCombo();

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주문수량", "SALES_OrderQty", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "SALES_Duedate", true, 100);
        }

        private void InitCombo() //콥보박스 바인딩
        {
            CommonCodeService service = new CommonCodeService();

            List<PlanIDVO> listPlanID = service.GetPlanIDByWorkOrder();

            CommonUtil.ComboBinding(cboPlanID, listPlanID, "Plan_ID", "Plan_ID");

        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboPlanID.Text.Length > 0)
            {
                string planID = cboPlanID.Text;

                HSM_Service service = new HSM_Service();

                List<SalesMasterWorkOrder> list = new List<SalesMasterWorkOrder>();
                list = service.GetSalesMasterByPlanID(planID);

                if (list.Count != 0)
                {
                    dataGridView1.DataSource = list;
                }
                else
                    return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cboPlanID.Text.Length>0)
            {
                string planID = cboPlanID.Text;

                HSM_Service service = new HSM_Service();

                if(service.InsertWorkOrder(planID))
                {
                    this.DialogResult = DialogResult.OK;
                }

            }
        }
    }
}
