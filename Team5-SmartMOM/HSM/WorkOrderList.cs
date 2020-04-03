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
    public partial class WorkOrderList : Team5_SmartMOM.BaseGridForm
    {
        public WorkOrderList()
        {
            InitializeComponent();
        }

        private void WorkOrderList_Load(object sender, EventArgs e)
        {
            dtpDateEnd.Value = DateTime.Now.AddMonths(1);
            dtpDateStart.Value = DateTime.Now.AddMonths(-2);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "작업지시번호", "WO_ID", true, 170, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Name", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비명", "FAC_Name", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "계획시작일", "WO_StartDate", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "WO_EndDate", true, 120,DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "계획수량", "planQty", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "지시수량", "directQty", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "작업상태", "WO_State", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "출고상태", "WO_OutState", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "Plan_ID", "Plan_ID", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소요시간(min)", "WO_Time", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "우선순위", "WO_Priority", false, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "양품수량", "WO_GoodQty", true, 80, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "불량수량", "WO_BadQty", true, 80, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "종료시간", "WO_WorkEndTime", true, 100, DataGridViewContentAlignment.MiddleCenter);
            
            InitCombo();
            DataLoad();
        }

        #region Settings

        private void InitCombo() //콥보박스 바인딩
        {
            CommonCodeService service = new CommonCodeService();

            List<CommonCodeVO> listWOstate = service.GetAllCommonCode();

            List<CommonCodeVO> WostateList = (from item in listWOstate
                                              where item.Common_Type == "WORK_ORDER_STATE"
                                                 select item).ToList();

            List<PlanIDVO> listPlanID = service.GetWorkOrderPlanID();

            CommonUtil.ComboBinding(cboWorkState, WostateList, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboPlanID, listPlanID, "Plan_ID", "Plan_ID", "전체");

        }
        private void DataLoad()
        {
            HSM_Service service = new HSM_Service();

            WorkOrderListVO wo = new WorkOrderListVO();
            wo.WO_StartDate = dtpDateStart.Value.ToShortDateString();
            wo.WO_EndDate = dtpDateEnd.Value.ToShortDateString();
            wo.WO_State = cboWorkState.Text;
            wo.Plan_ID = cboPlanID.Text;

            List<WorkOrderVO> list = new List<WorkOrderVO>();
            list = service.GetWorkOrderByPlan(wo);


            dataGridView1.DataSource = list;

        }
        #endregion

        #region btnClick Method
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            HSM_Service service = new HSM_Service();

            WorkOrderListVO wo = new WorkOrderListVO();
            wo.WO_StartDate = dtpDateStart.Value.ToShortDateString();
            wo.WO_EndDate = dtpDateEnd.Value.ToShortDateString();
            wo.WO_State = cboWorkState.Text;
            wo.Plan_ID = cboPlanID.Text;

            List<WorkOrderVO> list = new List<WorkOrderVO>();
            list = service.GetWorkOrderByPlan(wo);

            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e) //바코드출력
        {

            if (cboPlanID.Text != "전체" || cboWorkState.Text =="작업지시")
            {
                //using (CircleProgressBar frm = new CircleProgressBar(CreateBarcode))
                //{
                //    frm.ShowDialog(this);
                //}
                CreateBarcode();
            }
        }

        private void CreateBarcode()
        {
            DataTable dt = new DataTable();
            dt = setDataTable(dataGridView1); // 원하는 항목을 데이터테이블로 변환

            WorkOrderBarcode rpt = new WorkOrderBarcode();
            rpt.DataSource = dt;
            rpt.Parameters["Plan_ID"].Value = $"{cboPlanID.Text} ";
            rpt.Parameters["Plan_ID"].Visible = false;
            rpt.CreateDocument();


            ShowReport frm = new ShowReport(rpt);


            //frm.ShowDialog();
        }

        private DataTable setDataTable(DataGridView dgv)
        {

            DataTable dt = new DataTable(); // 담을 객체

     
            dt.Columns.Add("WO_ID", dgv.Columns[0].ValueType);
            dt.Columns.Add("ITEM_Code", dgv.Columns[1].ValueType);
            dt.Columns.Add("FAC_Name", dgv.Columns[3].ValueType);
            dt.Columns.Add("WO_StartDate", dgv.Columns[4].ValueType);
            dt.Columns.Add("WO_EndDate", dgv.Columns[5].ValueType);
            dt.Columns.Add("directQty", dgv.Columns[7].ValueType);
            
            //컬럼 생성
            // 0,1,3,4,5,7

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();


                dr[0] = dgv[0, i].Value;
                dr[1] = dgv[1, i].Value;
                dr[2] = dgv[3, i].Value;
                dr[3] = dgv[4, i].Value;
                dr[4] = dgv[5, i].Value;
                dr[5] = dgv[7, i].Value;

                dt.Rows.Add(dr);

            } //데이터 삽입
            dt.AcceptChanges();
            return dt;
        }

        #endregion
    }
}
