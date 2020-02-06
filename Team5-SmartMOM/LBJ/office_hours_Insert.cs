using Project_VO;
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
            List<CommonCodeVO> list = new List<CommonCodeVO>();
            CommonCodeService service = new CommonCodeService();
            list = service.GetAllCommonCode();
            //공통코드링큐
            List<CommonCodeVO> OrderUseList = (from item in list
                                                 where item.Common_Type == "USE_FLAG"
                                                 select item).ToList();

            CommonUtil.ComboBinding(cboUse, OrderUseList, "Common_Key", "Common_Value");
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
            if(txtStartTime.Text.Length < 1)
            {
                MessageBox.Show("시작시간을 입력해주세요.");
                this.txtStartTime.Focus(); 
            }
            ShiftVO svo = new ShiftVO();
            LBJ_Service service = new LBJ_Service();

            svo.SHIFT = cboShift.Text.Trim();
            svo.FAC_Code = cboCode.Text.Trim();
            svo.SHIFT_StartTime = Convert.ToInt32(txtStartTime.Text.Trim());
            svo.SHIFT_EndTime = Convert.ToInt32(txtCompleteTime.Text.Trim());
            svo.SHIFT_StartDate = dateTimePicker1.Value;
            svo.SHIFT_EndDate = dateTimePicker2.Value;
            svo.SHIFT_InputPeople = Convert.ToInt32(txtPeople.Text.Trim());
            svo.SHIFT_UserOrNot = cboUse.Text.Trim();
            svo.SHIFT_Modifier = txtReviceDay.Text.Trim();
            svo.SHIFT_ModifierDate = txtRevicePeople.Text.Trim();
            svo.SHIFT_Others = txtNote.Text.Trim();

            service.ShiftInsert(svo);
            MessageBox.Show("등록 완료");
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

      
    }
}
