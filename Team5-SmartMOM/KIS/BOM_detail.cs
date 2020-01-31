﻿using Project_VO;
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
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            try
            {
                if (cbo_differenceItem.Text == "")
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
                    list.BOM_Code = cbo_differenceItem.Text;
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

            init_Combo();

        }
        
        private void init_Combo()
        {
          
            cbo_differenceItem.DropDownStyle = ComboBoxStyle.DropDownList;

     
            CommonCodeService service = new CommonCodeService();
            KIS_Service service2 = new KIS_Service();
            List<CommonCodeVO> listGubunCode1 = service.GetAllCommonCode();
            List<CommonCodeVO> listGubunCode2 = service.GetAllCommonCode();
            List<CommonCodeVO> listGubunCode3 = service.GetAllCommonCode();
            List<ITEM_VO> listGubunCode4 = service2.GetAllCommonCode();
            List<BOM_VO1> listGubunCode5 = service2.GetAllCommonCode2();
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
            List<ITEM_VO> OrderGubunList4 = (from item in listGubunCode4
                                                  select item).ToList();   // 품목 유형
            List<BOM_VO1> OrderGubunList5 = (from item in listGubunCode5
                                             select item).ToList();   // 품목 유형
            
            CommonUtil.ComboBinding(cbo_UseorNot, OrderGubunList1, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_AutoDeduction, OrderGubunList2, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_Required_plan, OrderGubunList3, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cbo_Item, OrderGubunList4, "ITEM_Type", "ITEM_Name","4자리 이상 입력");
            CommonUtil.ComboBinding(cbo_differenceItem, OrderGubunList5, "ITEM_Type", "BOM_Code", "4자리 이상 입력");
        }

        private void Button1_Click_1(object sender, EventArgs e)
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
                else if (cbo_differenceItem.Text == ""||cbo_differenceItem.Text == "4자리 이상 입력")
                {
                    MessageBox.Show("상위 목록을 선택하여 주시기 바랍니다 \n 상위 목록이 없을경우 - 로 작성해주세요");
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
                else if (txt_Quantity.TextLength == 0)
                {
                    MessageBox.Show("소요량을 작성해 주시기 바랍니다..");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
                else if(cbo_Item.SelectedValue.ToString() == "반제품"||cbo_Item.SelectedValue.ToString() == "원자재" &&cbo_differenceItem.SelectedValue.ToString()=="제품")
                {
                    MessageBox.Show("상위품목 없는 원자재 및 반제품는 BOM으로 등록하실수 없습니다!");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }
             
                else if(cbo_Item.Text== "4자리 이상 입력"&&cbo_differenceItem.Text== "4자리 이상 입력")
                {
                    MessageBox.Show("상위 품목 혹은 품목을 정확하게 작성해 주시기 바랍니다!");
                    check = false;
                    this.DialogResult = DialogResult.None;
                }


                else if (check)
                {

                    BOM_VO list = new BOM_VO();
                    list.BOM_Code = cbo_differenceItem.Text;
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

        private void Cbo_Item_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_Item.Text != "4자리 이상 입력")
            {
                cbo_differenceItem.DropDownStyle = ComboBoxStyle.DropDown;
                cbo_differenceItem.Enabled = true;

            }
            else
            {
                cbo_differenceItem.DropDownStyle = ComboBoxStyle.DropDownList;
                cbo_differenceItem.Enabled = false;
            }
        }
    }
}
