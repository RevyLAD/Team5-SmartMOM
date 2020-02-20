using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.PSM
{
    public partial class Purchasing_Order : Form
    {        
        List<ComPanyListVO> list;        
        List<GetOrderVO> list2;
        private Purchasing mainForm;
        public Purchasing_Order(PlanIDVO listPlanID, Purchasing purchasing)
        {
            this.mainForm = purchasing;
            InitializeComponent();

            lblPlanID.Text = listPlanID.Plan_ID.ToString();
        }
        #region 데이터그리드뷰 체크박스 및 데이터그리드뷰 컬럼띄우기
        private void Purchasing_Order_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체번호", "COM_No", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체이름", "COM_Name", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체코드", "COM_Code", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주업체", "ITEM_OrderComp ", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주수량", "Vo_Quantity ", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "최소발주수량", "ITEM_MinOrderQuantity  ", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "Vo_EndDate", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수입검사여부", "ITEM_ImportIns ", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", false, 150);

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "업체이름", "COM_Name", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "업체타입", "COM_Type", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목명", "ITEM_Code", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "업체코드", "COM_Code", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목사이즈", "ITEM_Size", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "납기일자", "SALES_Duedate", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "개수", "SumQty", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "발주상태", "Order_State", true, 120, DataGridViewContentAlignment.MiddleCenter);

            DataLoad();
            
        }
        #endregion

        //콤보 바인딩 및 데이터 조회
        public void DataLoad()
        {
            PSM_Service service = new PSM_Service();
            list = service.GetAllPurChasing();
            dataGridView1.DataSource = list;


            string plan_id = lblPlanID.Text;
            PSM_Service service2 = new PSM_Service();
            list2 = service2.GetOrder(plan_id);
            dataGridView2.DataSource = list2;

                        

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.InitCombo();
            this.Close();
        }      
       

        private void btnOrder_Click(object sender, EventArgs e)
        {            
            List<VendorOrderVO> codelist = new List<VendorOrderVO>();
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                VendorOrderVO code = new VendorOrderVO();
                
                code.COM_Name = dataGridView2.Rows[i].Cells[0].Value.ToString();
                code.COM_Code = dataGridView2.Rows[i].Cells[2].Value.ToString();
                code.VO_EndDate = (DateTime)dataGridView2.Rows[i].Cells[5].Value;
                code.VO_Quantity = Convert.ToInt32(dataGridView2.Rows[i].Cells[6].Value);
                code.Plan_ID = lblPlanID.Text;
                codelist.Add(code);
            }
            PSM_Service service = new PSM_Service();
            service.VendorOrder(codelist);

            MessageBox.Show("발주처리가 완료 되었습니다.");
            dataGridView2.DataSource = null;

        }

    }
}


