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
    public partial class BOM_detail : Team5_SmartMOM.BasePopUpDialog
    {
        public BOM_detail()
        {
            InitializeComponent();
            txt_Revise_day.Text = DateTime.Now.ToString("yyyy-MM-dd");
            init_Combo();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            try
            {
                if (txt_differenceItem.Text == "")
                {
                    MessageBox.Show("상위 목록을 선택하여 주시기 바랍니다 \n 상위 목록이 없을경우 - 로 작성해주세요");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (cbo_Item.Text == null)
                {
                    MessageBox.Show("등록할 품목을 작성해주시기 바랍니다.");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (cbo_UseorNot.Text == null)
                {
                    MessageBox.Show("사용 유무를 선택해 주시기 바랍니다.");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (cbo_AutoDeduction.Text == null)
                {
                    MessageBox.Show("자동 차감할 양을 선택해 주시기 바랍니다..");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (cbo_Required_plan.Text == null)
                {
                    MessageBox.Show("소요 계획을 설정해 주시기 바랍니다.");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }

                else if (check)
                {

                    BOM_VO list = new BOM_VO();
                    list.BOM_Code = txt_differenceItem.Text;
                    list.ITEM_Code = cbo_Item.Text;
                    list.BOM_Require = Convert.ToInt32(txt_Quantity.Text);
                    list.BOM_StartDate = Convert.ToDateTime(dtp_Startdate.Text);
                    list.BOM_EndDate = Convert.ToDateTime(dtp_Enddate.Text);
                    list.BOM_UseOrNot = cbo_UseorNot.Text;
                    list.BOM_Modifier = txt_Reviser.Text;
                    list.BOM_ModifiyDate = Convert.ToDateTime(txt_Revise_day.Text);
                    list.BOM_AutoDeduction = cbo_AutoDeduction.Text;
                    list.BOM_RequirePlan = cbo_Required_plan.Text;
                    list.BOM_Others = txt_Remarks.Text;

                    KIS_Service service = new KIS_Service();
                    bool bResult = service.InsertBOM(list);

                    if (!bResult)
                    {
                        MessageBox.Show("성공적으로 등록되었습니다");

                    }
                    else
                    {
                        MessageBox.Show("등록중 오류가 발생하였습니다 다시 시도해주세요");
                    }
                }

            }
            catch
            {

            }
        }

        private void BOM_detail_Load(object sender, EventArgs e)
        {
           
          
        }
        private void init_Combo()
        {
            CommonCodeService service = new CommonCodeService();

            List<CommonCodeVO> listGubunCode1 = service.GetAllCommonCode();
            List<CommonCodeVO> listGubunCode2 = service.GetAllCommonCode();
            List<CommonCodeVO> listGubunCode3 = service.GetAllCommonCode();

            //공통코드링큐
            List<CommonCodeVO> OrderGubunList1 = (from item in listGubunCode1
                                                 where item.Common_Type == "USE_FLAG"
                                                 select item).ToList();
            List<CommonCodeVO> OrderGubunList2= (from item in listGubunCode2
                                                  where item.Common_Type == "USE_FLAG"
                                                  select item).ToList();
            List<CommonCodeVO> OrderGubunList3= (from item in listGubunCode3
                                                  where item.Common_Type == "USE_FLAG"
                                                  select item).ToList();
          
            
            CommonUtil.ComboBinding(cbo_UseorNot, OrderGubunList1, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_AutoDeduction, OrderGubunList2, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_Required_plan, OrderGubunList3, "Common_Key", "Common_Value");
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            bool check = true;
            try
            {
                if (txt_differenceItem.Text == "")
                {
                    MessageBox.Show("상위 목록을 선택하여 주시기 바랍니다 \n 상위 목록이 없을경우 - 로 작성해주세요");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (cbo_Item.Text == null)
                {
                    MessageBox.Show("등록할 품목을 작성해주시기 바랍니다.");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (cbo_UseorNot.Text == null)
                {
                    MessageBox.Show("사용 유무를 선택해 주시기 바랍니다.");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (cbo_AutoDeduction.Text == null)
                {
                    MessageBox.Show("자동 차감할 양을 선택해 주시기 바랍니다..");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (cbo_Required_plan.Text == null)
                {
                    MessageBox.Show("소요 계획을 설정해 주시기 바랍니다.");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }

                else if (check)
                {

                    BOM_VO list = new BOM_VO();
                    list.BOM_Code = txt_differenceItem.Text;
                    list.ITEM_Code = cbo_Item.Text;
                    list.BOM_Require = Convert.ToInt32(txt_Quantity.Text);
                    list.BOM_StartDate = Convert.ToDateTime(dtp_Startdate.Text);
                    list.BOM_EndDate = Convert.ToDateTime(dtp_Enddate.Text);
                    list.BOM_UseOrNot = cbo_UseorNot.Text;
                    list.BOM_Modifier = txt_Reviser.Text;
                    list.BOM_ModifiyDate = Convert.ToDateTime(txt_Revise_day.Text);
                    list.BOM_AutoDeduction = cbo_AutoDeduction.Text;
                    list.BOM_RequirePlan = cbo_Required_plan.Text;
                    list.BOM_Others = txt_Remarks.Text;

                    KIS_Service service = new KIS_Service();
                    bool bResult = service.InsertBOM(list);

                    if (!bResult)
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
