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
    public partial class WorkOrderList : Team5_SmartMOM.BaseGridForm
    {
        public WorkOrderList()
        {
            InitializeComponent();
        }

        private void WorkOrderList_Load(object sender, EventArgs e)
        {

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "Plan_ID", "Plan_ID", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "작업지시번호", "WO_ID", true, 170);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Name", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비명", "FAC_Name", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "계획시작일", "WO_StartDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "WO_EndDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "계획수량", "planQty", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "지시수량", "directQty", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "상태", "WO_State", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소요시간(min)", "WO_Time", true, 130);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "우선순위", "WO_Priority", true, 100);

            DataLoad();
        }

        private void DataLoad()
        {
            HSM_Service service = new HSM_Service();

            List<WorkOrderVO> list = new List<WorkOrderVO>();
            list = service.GetWorkOrderByPlan();


            dataGridView1.DataSource = list;

        }
    }


}
