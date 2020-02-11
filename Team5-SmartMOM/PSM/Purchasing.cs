using Project_VO;
using Project_VO.HSM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5_SmartMOM.BaseForm;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.PSM
{
    public partial class Purchasing : BaseGridForm
    {
        List<PlanIDVO> listPlanID;
        public Purchasing()
        {
            InitializeComponent();
        }

        private void Purchasing_Load(object sender, EventArgs e)
        {
            dtpDateStart.Value = DateTime.Now;
            dtpDateEnd.Value = DateTime.Now.AddMonths(1);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);            
            InitCombo();
        }

        public void InitCombo()
        {
            CommonCodeService service = new CommonCodeService();
            listPlanID = service.GetAllPlanID();

            //콤보박스 콤보바인딩
            CommonUtil.ComboBinding(cboPlanID, listPlanID, "Plan_ID", "Plan_ID");
        }

        //발주 팝업창
        private void button2_Click(object sender, EventArgs e)
        {
            PlanIDVO listPlanID = new PlanIDVO();
            listPlanID.Plan_ID = cboPlanID.Text;

            Purchasing_Order frm = new Purchasing_Order(listPlanID);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        //데이트타임피커 기준정보
        private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateStart.Value > dtpDateEnd.Value.AddDays(1))
            {
                MessageBox.Show("시작일보다 빠를 수 없습니다.");
                dtpDateEnd.Value = dtpDateStart.Value.AddMonths(1);
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PlanningVO plan = new PlanningVO();
            HSM_Service service = new HSM_Service();

            plan.PlanId = cboPlanID.Text;
            plan.SALES_OrderDate = dtpDateStart.Value.ToShortDateString();
            plan.SALES_DueDate = dtpDateEnd.Value.ToShortDateString();

            DataSet ds = service.GetMRP(plan);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {            
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 3; j < dataGridView1.ColumnCount; j++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value) != 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;                        
                    }
                }
            }
        }
    }
}
