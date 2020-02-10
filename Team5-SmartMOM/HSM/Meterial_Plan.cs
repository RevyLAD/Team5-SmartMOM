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
    public partial class Meterial_Plan : Team5_SmartMOM.BaseGridForm
    {
        int cnt = 0; 
        public Meterial_Plan()
        {
            InitializeComponent();
        }

        private void Meterial_Plan_Load(object sender, EventArgs e)
        {
            dtpDateEnd.Value = DateTime.Now.AddMonths(1);
           
            InitCombo();

        }
        private void InitCombo()
        {
            CommonCodeService service = new CommonCodeService();

            List<PlanIDVO> listPlanID = service.GetPlanIDByDemandPlan();



            CommonUtil.ComboBinding(cboPlanID, listPlanID, "Plan_ID", "Plan_ID");

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            

            PlanningVO plan = new PlanningVO();
            HSM_Service service = new HSM_Service();

            plan.PlanId = cboPlanID.Text;
            plan.SALES_OrderDate = dtpDateStart.Value.ToShortDateString();
            plan.SALES_DueDate = dtpDateEnd.Value.ToShortDateString();

    
            DataSet ds = service.GetMRP(plan);
            dataGridView1.DataSource = ds.Tables[0];
 
            dgvSettings();
            dgvYellow();


        }
        private void dgvSettings()
        {

            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[0].Width = 180;

            dataGridView1.Columns[0].HeaderText = "상품코드";
            dataGridView1.Columns[1].HeaderText = "상품명";
            dataGridView1.Columns[2].HeaderText = "카테고리";

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }
        private void dgvYellow()
        {

            for (int i = 3; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (dataGridView1[i, j].Value.ToString() != "0")
                    {
                        dataGridView1[i, j].Style.BackColor = Color.LightYellow;
                    }
                }
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

        private void dtpDateStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateStart.Value > dtpDateEnd.Value)
            {
                MessageBox.Show("종료일보다 늦을 수 없습니다.");
                dtpDateStart.Value = dtpDateEnd.Value.AddMonths(-1);
                return;
            }
        }

        private void cboPlanID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] arrDate = cboPlanID.Text.Split('_');
            if (arrDate[0] == "전체")
            {
                return;
            }
            if (arrDate[0] == "Project")
            {
                return;
            }
            arrDate[0] = arrDate[0].Insert(4, "-");
            arrDate[0] = arrDate[0].Insert(7, "-");
            //20200101
            dtpDateStart.Value = DateTime.Parse(arrDate[0]);
            dtpDateEnd.Value = DateTime.Parse(arrDate[0]).AddMonths(1);

        }
    }
}
