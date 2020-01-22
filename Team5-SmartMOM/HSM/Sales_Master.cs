using Project_VO;
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
    public partial class Sales_Master : Team5_SmartMOM.BaseGridForm
    {
        public Sales_Master()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //영업마스터 생성
        {
            HSM_Service service = new HSM_Service();
            dataGridView1.DataSource= service.GetAllSalesMaster();

        }

        private void Sales_Master_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "고객WO", "SO_WorkOrderID", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "고객사코드", "COM_Code", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "고객사명", "COM_Name", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주문유형", "PO_Type", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주문수량", "SALES_OrderQty", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "출고수량", "SALES_ShipQty", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "취소수량", "SALES_CancelQty", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "SALES_Duedate", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주문일", "SALES_OrderDate", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "SALES_Remark", true,380);

            InitCombo();

        }

        private void InitCombo()
        {
            CommonCodeService service = new CommonCodeService();

            List<CommonCodeVO> listGubunCode = service.GetAllCommonCode();
            List<CompanyCodeVO> listCompanyCode = service.GetAllCompanyCode();
            List<ItemCodeVO> listItemCode = service.GetAllItemCode();


            //공통코드링큐
            List<CommonCodeVO> OrderGubunList = (from item in listGubunCode
                                                 where item.Common_Type == "ORDER_GUBUN"
                                                 select item).ToList();


            CommonUtil.ComboBinding(cboState, OrderGubunList, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboCustomer, listCompanyCode, "COM_Code", "COM_Name");
            CommonUtil.ComboBinding(cboProduct, listItemCode, "ITEM_Code", "ITEM_Name");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SO_Insert frm = new SO_Insert();
            frm.StartPosition = FormStartPosition.CenterScreen;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                button2.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MPS frm = new MPS();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}
