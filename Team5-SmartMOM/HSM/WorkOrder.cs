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
    public partial class WorkOrder : Team5_SmartMOM.BaseGridForm
    {
        public WorkOrder()
        {
            InitializeComponent();
        }

        private void WorkOrder_Load(object sender, EventArgs e)
        {
            InitCombo();


            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "작업지시번호", "WO_ID", true, 170);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목", "ITEM_Code", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목", "ITEM_Name", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "설비명", "FAC_Name", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "계획시작일", "WO_StartDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "계획종료일", "WO_EndDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "계획수량", "planQty", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "지시수량", "directQty", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "상태", "WO_State", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "Plan_ID", "Plan_ID", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "소요시간(min)", "WO_Time", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "우선순위", "WO_Priority", true, 100);


    }

        private void InitCombo() //콥보박스 바인딩
        {
            CommonCodeService service = new CommonCodeService();

            List<PlanIDVO> listPlanID = service.GetPlanIDByWorkOrder2();

            CommonUtil.ComboBinding(cboPlanID, listPlanID, "Plan_ID", "Plan_ID");

        }
        /// <summary>
        /// 작업지시 생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            WorkOrderPoPUp frm = new WorkOrderPoPUp();
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                InitCombo();
                btnSearch.PerformClick();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cboPlanID.Text.Length>0)
            {
                string planId = cboPlanID.Text;
                HSM_Service service = new HSM_Service();

                    List<WorkOrderVO> list = new List<WorkOrderVO>();
                list = service.GetWorkOrderByPlanId(planId);

                if (list.Count != 0)
                {
                    dataGridView2.DataSource = list;
                }
                else
                    MessageBox.Show("조회결과없음", "확인");


            }

        }
    }
}
