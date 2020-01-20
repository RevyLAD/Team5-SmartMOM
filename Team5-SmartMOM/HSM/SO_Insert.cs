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
    public partial class SO_Insert : Team5_SmartMOM.BasePopUpDialog
    {
        public SO_Insert()
        {
            InitializeComponent();
        }

 

        private void SO_Insert_Load(object sender, EventArgs e)
        {
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


            CommonUtil.ComboBinding(cboOrderDivision, OrderGubunList, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboCustomer, listCompanyCode, "COM_Code", "COM_Name");
            CommonUtil.ComboBinding(cboProduct, listItemCode, "ITEM_Code", "ITEM_Name");

        }

        private void button1_Click(object sender, EventArgs e) //저장
        {
            if(txtCustomerWO.TextLength > 0 || txtOrderQuantity.TextLength > 0)
            {
                if (txtShippingQuantity.Text == "")
                    txtShippingQuantity.Text = "0";
                if (txtCancelQuantity.Text == "")
                    txtCancelQuantity.Text = "0";

                SalesMasterAllVO sale = new SalesMasterAllVO();

                sale.SO_WorkOrderID = txtCustomerWO.Text.Trim();
                sale.PO_Type = cboOrderDivision.Text;
                sale.ITEM_Code = cboProduct.SelectedValue.ToString();
                sale.COM_Code = cboCustomer.SelectedValue.ToString();
                sale.SALES_Duedate = dtpDueDate.Value.ToShortDateString();
                sale.SALES_OrderQty = Convert.ToInt32(txtOrderQuantity.Text);
                sale.SALES_ShipQty = Convert.ToInt32(txtShippingQuantity.Text);
                sale.SALES_CancelQty = Convert.ToInt32(txtCancelQuantity.Text);
                sale.SALES_Remark = txtNote.Text;

                HSM_Service service = new HSM_Service();

                if (service.UploadPassiveSalesMaster(sale))
                {
                    MessageBox.Show("영업마스터가 저장되었습니다.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("저장실패");
                }
            }

            else
            {
                MessageBox.Show("필수항목을 입력해주세요.");
            }
            
        }
    }
}
