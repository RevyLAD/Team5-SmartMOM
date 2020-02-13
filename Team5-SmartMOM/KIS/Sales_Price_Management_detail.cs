using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.BaseForm;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM
{
    public partial class Sales_Price_Management_detail : Team5_SmartMOM.BasePopUpDialog
    {
        public Sales_Price_Management_detail()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            try
            {
                if (cbo_item.Text == "" || cbo_item.Text == "4자리 이상 입력")
                {
                    MessageBox.Show("등록할 품목을 작성해주시기 바랍니다.");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if(cbo_Company.Text == "" || cbo_Company.Text == "4자리 이상 입력")
                {
                    MessageBox.Show("등록할 업체을 작성해주시기 바랍니다.");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (txt_now_Price.Text == "")
                {
                    MessageBox.Show("현재 단가를 작성해주시기 바랍니다.");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (txt_Forgotten_price.Text == "")
                {
                    MessageBox.Show("이전 단가를 작성해주시기 바랍니다.");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if (check)
                {
                    Sales_VO list = new Sales_VO();
                    list.COM_Code = cbo_Company.SelectedValue.ToString();
                    list.ITEM_Code = cbo_item.Text;
                    list.Sales_Price_Now = Convert.ToInt32(txt_now_Price.Text);
                    list.Sales_Price_Previous = Convert.ToInt32(txt_Forgotten_price.Text);
                    list.Sales_StartDate = Convert.ToDateTime(dtp_start_date.Text);
                    list.Sales_EndDate = Convert.ToDateTime(txt_end_date.Text);
                    list.Sales_UseOrNot = cbo_UseorNot.Text;
                    list.Sales_Editer = txt_edit_user.Text;
                    list.Sales_EditDate = Convert.ToDateTime(txt_edit_date.Text);
                    list.Sales_Others = txt_Remarks.Text;


                    KIS_Service service = new KIS_Service();
                    SqlParameter bResult = service.InsertISales(list);

                    if (bResult.Value.ToString() == "1")
                    {
                        MessageBox.Show($"{list.COM_Code}업체의 {list.ITEM_Code}의 단가가 성공적으로 등록되었습니다 \n 현재 날짜를 기준으로 화면이 재구성됩니다.", "확인", MessageBoxButtons.OK);

                    }
                    else if (bResult.Value.ToString() == "0")
                    {
                        MessageBox.Show("시작일에 등록된 월중 등록된 품목의 중복값이 확인되었습니다. \n 중복된 월에는 등록하실수 없습니다!", "경고");
                        this.DialogResult = DialogResult.None;
                    }
                    else
                    {
                        MessageBox.Show("등록중 문제가 발생하여 등록을 하지 못하였습니다. 다시 등록해주시기 바랍니다. ");
                        this.DialogResult = DialogResult.None;
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
         }
        private void Sales_Price_Management_detail_Load(object sender, EventArgs e)
        {
            Init_Combo();
            txt_end_date.Text = "2099-12-30";
            txt_edit_date.Text = DateTime.Now.ToString("yyyy-MM-dd");
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
            CommonUtil.ComboBinding(cbo_item, OrderGubunList4, "ITEM_Code", "ITEM_Code");
            CommonUtil.ComboBinding(cbo_Company, OrderGubunList3, "COM_Code", "COM_Name");
        }
    }
}
