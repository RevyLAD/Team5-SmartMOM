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
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvYellow();
        }

        private void InitCombo() //콥보박스 바인딩
        {
            CommonCodeService service = new CommonCodeService();

            //작업대기 planID
            List<PlanIDVO> listPlanID = service.GetPlanIDByProduction();
            List<ItemCodeVO> listItemCode = service.GetAllItemCode();

            CommonUtil.ComboBinding(cboPlanID, listPlanID, "Plan_ID", "Plan_ID");
            CommonUtil.ComboBinding(cboProduct, listItemCode, "ITEM_Code", "ITEM_Name", "");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            PlanningVO plan = new PlanningVO();
            HSM_Service service = new HSM_Service();

            plan.PlanId = cboPlanID.Text;
            plan.SALES_OrderDate = dtpDateStart.Value.ToShortDateString();
            plan.SALES_DueDate = dtpDateEnd.Value.ToShortDateString();


            DataSet ds = service.GetProductPlan(plan);
            dataGridView1.DataSource = ds.Tables[0];

            dgvSettings();
                   
        }

        private void dgvSettings()
        {            
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 180;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 80;

            dataGridView1.Columns[0].HeaderText = "설비";
            dataGridView1.Columns[1].HeaderText = "공정";
            dataGridView1.Columns[2].HeaderText = "품목";
            dataGridView1.Columns[3].HeaderText = "품명";
            dataGridView1.Columns[4].HeaderText = "규격";
            dataGridView1.Columns[5].HeaderText = "우선순위";

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void dgvYellow()
        {
            for (int i = 6; i < dataGridView1.ColumnCount; i++)
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
