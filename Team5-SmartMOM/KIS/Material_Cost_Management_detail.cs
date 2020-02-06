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
    public partial class Material_Cost_Management_detail : Team5_SmartMOM.BasePopUpDialog
    {
        public Material_Cost_Management_detail()
        {
            InitializeComponent();
        }


        private void Init_Combo()
        {
            CommonCodeService service = new CommonCodeService();
            KIS_Service service2 = new KIS_Service();
            List<CommonCodeVO> listGubunCode1 = service.GetAllCommonCode();
            List<ITEM_VO> listGubunCode4 = service2.GetAllCommonItem();
            List<EnterpriseVO> listGubunCode3 = service2.GetAllCommonCode3();

            //공통코드링큐
            List<CommonCodeVO> OrderGubunList1 = (from item in listGubunCode1
                                                  where item.Common_Type == "USE_FLAG"
                                                  select item).ToList();

            List<ITEM_VO> OrderGubunList4 = (from item in listGubunCode4
                                             select item).ToList();   // 품목 유형

            List<EnterpriseVO> OrderGubunList3 = (from item in listGubunCode3
                                                  select item).ToList();   // 품목 유형

            CommonUtil.ComboBinding(cbo_UseorNot, OrderGubunList1, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_Item, OrderGubunList4, "ITEM_Code", "ITEM_Code");
            CommonUtil.ComboBinding(cbo_Company, OrderGubunList3, "COM_Code", "COM_Code");
        }

        private void Material_Cost_Management_detail_Load(object sender, EventArgs e)
        {
            Init_Combo();
            txt_end_date.Text = "2099-12-29";
            txt_edit_date.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            try
            {



                if (cbo_Item.Text == null || cbo_Item.Text == "4자리 이상 입력")
                {
                    MessageBox.Show("등록할 품목을 작성해주시기 바랍니다.");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (check)
                {
                    Material_VO list = new Material_VO();
                    list.COM_Code = cbo_Company.Text;
                    list.ITEM_Code = cbo_Item.Text;
                    list.Material_Price_Now= Convert.ToInt32(txt_now_Price.Text);
                    list.Material_Price_Previous = Convert.ToInt32(txt_Forgotten_price.Text);
                    list.Material_StartDate = Convert.ToDateTime(dtp_start_date.Text);
                    list.Material_EndDate = Convert.ToDateTime(txt_end_date.Text);
                    list.Material_UseOrNot = cbo_UseorNot.Text;
                    list.Material_Editer = txt_edit_user.Text;
                    list.Material_EditDate = Convert.ToDateTime(txt_edit_date.Text);
                    list.Material_Others = txt_Remarks.Text;
                  

                    KIS_Service service = new KIS_Service();
                    bool bResult = service.InsertIMaterial(list);

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

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}

