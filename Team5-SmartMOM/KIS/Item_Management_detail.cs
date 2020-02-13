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
            KIS_Service service1 = new KIS_Service();

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
            List<FactoryVO> listGubunCode12 = service1.GetAllFactoryCode();
            List<FactoryVO> listGubunCode13 = service1.GetAllFactoryCode();

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
            List<FactoryVO> OrderGubunList12 = (from item in listGubunCode12
                                                   select item).ToList();  //발주방식 
            List<FactoryVO> OrderGubunList13 = (from item in listGubunCode13
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
            CommonUtil.ComboBinding(cbo_orderType, OrderGubunList11, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_Warehouse, OrderGubunList12, "FACT_Name", "FACT_Name");
            CommonUtil.ComboBinding(cbo_releasehouse, OrderGubunList13, "FACT_Name", "FACT_Name");
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            try
            {
                if (txt_item.Text == "")
                {
                    MessageBox.Show("품목을 작성해주시기 바랍니다.", "경고");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (txt_itemname.Text == null)
                {
                    MessageBox.Show("등록할 품명을 작성해주시기 바랍니다.", "경고");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (cbo_unit.Text == null)
                {
                    MessageBox.Show("단위를 작성해 주시기 바랍니다.", "경고");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (cbo_itemtype.Text == null)
                {
                    MessageBox.Show("품목 유형을 선택해 주시기 바랍니다..", "경고");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (cbo_import_check.Text == null)
                {
                    MessageBox.Show("수입검사여부를 설정해 주시기 바랍니다.", "경고");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (cbo_process_check.Text == null)
                {
                    MessageBox.Show("공장검사여부를 설정해 주시기 바랍니다.", "경고");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (cbo_shipment_Check.Text == null)
                {
                    MessageBox.Show("출하검사여부를 설정해 주시기 바랍니다.", "경고");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (cbo_UseorNot.Text == null)
                {
                    MessageBox.Show("사용유무를 설정해 주시기 바랍니다.", "경고");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (txt_Safety_Count.Text == null || cbo_MinOrder_count.Text == null)
                {
                    MessageBox.Show("최소발주수량 혹은 안전재고수량을 작성해주시기바랍니다 \n 수량이 0인경우 0으로 작성해주시기바랍니다.","경고");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
               else if(check)
                {
                    ITEM_VO item = new ITEM_VO();
                    item.ITEM_Name = txt_itemname.Text;
                    item.ITEM_Code = txt_item.Text;
                    item.ITEM_Size = txt_size.Text;
                    item.ITEM_Unit = cbo_unit.Text;
                    item.ITEM_Type = cbo_itemtype.Text;
                    item.ITEM_ImportIns = cbo_import_check.Text;
                    item.ITEM_ProcessIns = cbo_process_check.Text;
                    item.ITEM_ShipmentIns = cbo_shipment_Check.Text;
                    item.ITEM_OrderComp = cbo_Client.Text;
                    item.ITEM_InWarehouse = cbo_Warehouse.Text;
                    item.ITEM_OutWarehouse = cbo_releasehouse.Text;
                    item.ITEM_MinOrderQuantity =Convert.ToInt32(cbo_MinOrder_count.Text);
                    item.ITEM_SafeQuantity =Convert.ToInt32(txt_Safety_Count.Text);
                    item.ITEM_Grade = cbo_Management_ranking.Text;
                    item.ITEM_Manager = cbo_manager.Text;
                    item.ITEM_Modifier = txt_edituser.Text;
                    item.ITEM_ModifiyDate =Convert.ToDateTime(txt_edit_date.Text);
                    item.ITEM_UserOrNot = cbo_UseorNot.Text;
                    item.ITEM_OrderMethod = cbo_orderType.Text;
                    item.ITEM_Others = txt_Remarks.Text;

                    KIS_Service service = new KIS_Service();
                    bool bResult= service.InsertItem(item);

                    if (bResult)
                    {
                        MessageBox.Show("성공적으로 등록되었습니다");

                    }
                    else
                    {
                        MessageBox.Show("등록중 오류가 발생하였습니다 다시 시도해주세요");
                    }

                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
    }
}
