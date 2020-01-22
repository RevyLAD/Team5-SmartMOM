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

namespace Team5_SmartMOM
{
    public partial class Item_Management_detail : Team5_SmartMOM.BasePopUpDialog
    {
        public Item_Management_detail()
        {
            InitializeComponent();
        }

        private void Item_Management_detail_Load(object sender, EventArgs e)
        {
            txt_edit_date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            init_Combo();
        }

        private void init_Combo()
        {
            CommonCodeService service = new CommonCodeService();

            List<CommonCodeVO> listGubunCode1 = service.GetAllCommonCode();
            List<CommonCodeVO> listGubunCode2 = service.GetAllCommonCode();   
            List<CommonCodeVO> listGubunCode4 = service.GetAllCommonCode();
            List<CommonCodeVO> listGubunCode5 = service.GetAllCommonCode();
            List<CommonCodeVO> listGubunCode6 = service.GetAllCommonCode();
            List<CommonCodeVO> listGubunCode7 = service.GetAllCommonCode();
            List<CommonCodeVO> listGubunCode8 = service.GetAllCommonCode();
            List<CommonCodeVO> listGubunCode9 = service.GetAllCommonCode();
            List<CommonCodeVO> listGubunCode10 = service.GetAllCommonCode();
            List<CommonCodeVO> listGubunCode11 = service.GetAllCommonCode();


            List<CommonCodeVO> OrderGubunList1 = (from item in listGubunCode1
                                                  where item.Common_Type == "ITEM_TYPE"
                                                  select item).ToList();   // 품목 유형
            List<CommonCodeVO> OrderGubunList2 = (from item in listGubunCode2
                                                  where item.Common_Type == "ITEM_UNIT"
                                                  select item).ToList(); //단위
            List<CommonCodeVO> OrderGubunList4 = (from item in listGubunCode4
                                                  where item.Common_Type == "USE_FLAG"
                                                  select item).ToList(); //수입 검사 여부
            List<CommonCodeVO> OrderGubunList5 = (from item in listGubunCode5
                                                  where item.Common_Type == "USE_FLAG"
                                                  select item).ToList();// 출하 검사 여부 
            List<CommonCodeVO> OrderGubunList6 = (from item in listGubunCode6
                                                  where item.Common_Type == "USE_FLAG"
                                                  select item).ToList();  //공정 검사 여부  
            List<CommonCodeVO> OrderGubunList7 = (from item in listGubunCode7
                                                  where item.Common_Type == "FACILITY_TYPE"
                                                  select item).ToList();  //입고 창고  
            List<CommonCodeVO> OrderGubunList8 = (from item in listGubunCode8
                                                  where item.Common_Type == "FACILITY_TYPE"
                                                  select item).ToList();  //출고 창고 
            List<CommonCodeVO> OrderGubunList9 = (from item in listGubunCode9
                                                  where item.Common_Type == "ORDER_METHOD"
                                                  select item).ToList();  //관리 등급 
            List<CommonCodeVO> OrderGubunList10 = (from item in listGubunCode10
                                                  where item.Common_Type == "USE_FLAG"
                                                   select item).ToList();  //사용유무 
            List<CommonCodeVO> OrderGubunList11 = (from item in listGubunCode11
                                                   where item.Common_Type == "MATERIAL_ORDER_STATE"
                                                   select item).ToList();  //발주방식 

            CommonUtil.ComboBinding(cbo_itemtype, OrderGubunList1, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_unit, OrderGubunList2, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_import_check, OrderGubunList4, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_process_check, OrderGubunList5, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_shipment_Check, OrderGubunList6, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_Warehouse, OrderGubunList7, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_releasehouse, OrderGubunList8, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_Management_ranking, OrderGubunList9, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_UseorNot, OrderGubunList10, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_orderType, OrderGubunList10, "Common_Key", "Common_Value");
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
