﻿using Project_VO;
using Project_VO.LBJ;
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

namespace Team5_SmartMOM.LBJ
{
    public partial class office_hours_Insert : Team5_SmartMOM.BasePopUpDialog
    {
        public office_hours_Insert()
        {
            InitializeComponent();
            txtStartTime.ForeColor = SystemColors.GrayText;
            txtStartTime.Text = "숫자만 입력 가능";
            this.txtStartTime.Enter += new System.EventHandler(this.txtStartTime_Enter);
            this.txtStartTime.Leave += new System.EventHandler(this.txtStartTime_Leave);

            txtCompleteTime.ForeColor = SystemColors.GrayText;
            txtCompleteTime.Text = "숫자만 입력 가능";
            this.txtCompleteTime.Enter += new System.EventHandler(this.txtCompleteTime_Enter);
            this.txtCompleteTime.Leave += new System.EventHandler(this.txtCompleteTime_Leave);
        }

        private void office_hours_Insert_Load(object sender, EventArgs e)
        {
            txtReviceDay.Text = DateTime.Now.ToString();
            DataLoad();
            DataLoad2();
            DataLoad3();
            
        }
        public void DataLoad()
        {
            HSC_Service hscservice = new HSC_Service();
            List<FacilitieDetailVO> facvo = hscservice.GetAllFacilitiesDetail();
            List<CommonCodeVO> list = new List<CommonCodeVO>();
            CommonCodeService service = new CommonCodeService();
            list = service.GetAllCommonCode();
            //공통코드링큐
            List<CommonCodeVO> OrderUseList = (from item in list
                                               where item.Common_Type == "USE_FLAG"
                                               select item).ToList();

            CommonUtil.ComboBinding(cboUse, OrderUseList, "Common_Key", "Common_Value");            
            CommonUtil.ComboBinding(cboFacName, facvo, "FAC_No", "FAC_Name");
        }
        public void DataLoad2()
        {
            List<CommonCodeVO> list = new List<CommonCodeVO>();
            CommonCodeService service = new CommonCodeService();
            list = service.GetAllCommonCode();

            //공통코드링큐
            List<CommonCodeVO> OrderShiftList = (from item in list
                                                 where item.Common_Type == "SHIFT"
                                                 select item).ToList();

            CommonUtil.ComboBinding(cboShift, OrderShiftList, "Common_Key", "Common_Value");
        }
        public void DataLoad3()
        {
            List<FacilitieDetailVO> list = new List<FacilitieDetailVO>();

            HSC_Service service = new HSC_Service();

            list = service.GetAllFacilitiesDetail();
            string FacCode = cboCode.Text.Trim();

            List<FacilitieDetailVO> temp = (from item in list
                                            where item.FAC_Code.Contains(FacCode)
                                            select item).Distinct().ToList();



            List<FacilitieDetailVO> FacList = new List<FacilitieDetailVO>();

            foreach (FacilitieDetailVO item1 in temp)
            {
                bool addok = true;
                if (FacList.Count < 1)
                    FacList.Add(item1);
                else
                {
                    for (int i = 0; i < FacList.Count; i++)
                        if (FacList[i].FAC_Code.Trim() == item1.FAC_Code.Trim())
                            addok = false;

                    if (addok)
                        FacList.Add(item1);
                    else
                        continue;
                }
            }

            CommonUtil.ComboBinding(cboCode, FacList, "FAC_No", "FAC_Code");
        }
        private void button1_Click(object sender, EventArgs e)
        {          
            if (cboShift.Text.Trim() != "" && cboCode.Text.Trim() != "" && txtStartTime.Text.Trim() != "" &&
                txtCompleteTime.Text.Trim() != "" && txtPeople.Text.Trim() != "" && cboUse.Text.Trim() != "")
            {
                ShiftVO svo = new ShiftVO();
                LBJ_Service service = new LBJ_Service();

                svo.SHIFT = cboShift.Text.Trim();
                svo.FAC_Name = cboFacName.Text.Trim();
                svo.FAC_Code = cboCode.Text.Trim();
                svo.SHIFT_StartTime = Convert.ToInt32(txtStartTime.Text.Trim());
                svo.SHIFT_EndTime = Convert.ToInt32(txtCompleteTime.Text.Trim());
                svo.SHIFT_StartDate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
                svo.SHIFT_EndDate = Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString());
                svo.SHIFT_InputPeople = int.Parse(txtPeople.Text);
                svo.SHIFT_UserOrNot = cboUse.Text.Trim();
                svo.SHIFT_Modifier = txtReviceDay.Text.Trim();
                svo.SHIFT_ModifierDate = txtRevicePeople.Text.Trim();
                svo.SHIFT_Others = txtNote.Text.Trim();

                service.ShiftInsert(svo);
                MessageBox.Show("등록 완료", "완료", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("필수 항목을 입력해주세요.", "등록실패", MessageBoxButtons.OK);

        }
        private void txtStartTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txtCompleteTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

       

        private void txtStartTime_Enter(object sender, EventArgs e)
        {
            if (txtStartTime.Text == "숫자만 입력 가능")
            {
                txtStartTime.Text = "";
                txtStartTime.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtStartTime_Leave(object sender, EventArgs e)
        {
            if (txtStartTime.Text.Length == 0)
            {
                txtStartTime.Text = "숫자만 입력 가능";
                txtStartTime.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtCompleteTime_Enter(object sender, EventArgs e)
        {
            if (txtCompleteTime.Text == "숫자만 입력 가능")
            {
                txtCompleteTime.Text = "";
                txtCompleteTime.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtCompleteTime_Leave(object sender, EventArgs e)
        {
            if (txtCompleteTime.Text.Length == 0)
            {
                txtCompleteTime.Text = "숫자만 입력 가능";
                txtCompleteTime.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
