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


    }
}
