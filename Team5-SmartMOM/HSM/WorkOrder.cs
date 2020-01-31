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

        CheckBox headerCheckBox = new CheckBox();
        public WorkOrder()
        {
            InitializeComponent();
        }

        private void WorkOrder_Load(object sender, EventArgs e)
        {
            InitCombo();


            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "chk";
            chk.Width = 30;
            dataGridView1.Columns.Add(chk);

            Point headerLocation = dataGridView1.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox.Location = new Point(headerLocation.X + 8, headerLocation.Y + 4);
            headerCheckBox.BackColor = Color.White;
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += new EventHandler(HeaderCheckBox_Click);
            dataGridView1.Controls.Add(headerCheckBox);

            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView2_CellContentClick);
            DataLoad();


        }

        private void DataLoad()
        {

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "작업지시번호", "WO_ID", true, 170);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Name", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비명", "FAC_Name", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "계획시작일", "WO_StartDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "WO_EndDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "계획수량", "planQty", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "지시수량", "directQty", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "상태", "WO_State", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "Plan_ID", "Plan_ID", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소요시간(min)", "WO_Time", true, 130);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "우선순위", "WO_Priority", true, 100);
        }
        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["chk"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox.Checked;
                
            }
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
            dataGridView1.DataSource = null;
            DataLoad(); 
            if (cboPlanID.Text.Length > 0)
            {
                string planId = cboPlanID.Text;
                HSM_Service service = new HSM_Service();

                List<WorkOrderVO> list = new List<WorkOrderVO>();
                list = service.GetWorkOrderByPlanId(planId);

                if (list.Count != 0)
                {
                    dataGridView1.DataSource = list;
                }
                else
                    MessageBox.Show("조회결과없음", "확인");

            }

        }

        private void button2_Click(object sender, EventArgs e) //작업지시확정
        {

            List<WorkOrderVO> list = new List<WorkOrderVO>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isCellChecked = Convert.ToBoolean(row.Cells["chk"].EditedFormattedValue);

                if (isCellChecked)
                {
                    WorkOrderVO wo = new WorkOrderVO();
                    wo.WO_ID = row.Cells[1].Value.ToString();

                    list.Add(wo);

                }
            }

            HSM_Service service = new HSM_Service();
            if(service.UpdateWorkOrderConfirm(list))
            {
                MessageBox.Show("작업확정완료", "확인");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show("실패");
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool isChecked = true;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["chk"].EditedFormattedValue) == false)
                    {
                        isChecked = false;
                        break;
                    }
                }
                headerCheckBox.Checked = isChecked;
            }
        }
    }
}
