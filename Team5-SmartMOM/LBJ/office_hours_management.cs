using Project_VO;
using Project_VO.HSM;
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
    public partial class office_hours_management : Team5_SmartMOM.BaseGridForm
    {
        List<ShiftManagementVO> list;
        public office_hours_management()
        {
            InitializeComponent();
        }

        DateTimePicker dtp;
        private void office_hours_management_Load(object sender, EventArgs e)
        {
            dtp = new DateTimePicker();
            dateTimePicker1.Value = dtp.Value = DateTime.Now.AddDays(-7);

            //UtilityClass.InitSettingDridView(dataGridView1);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataLoad();
            DataLoad2();
        }
        public void DataLoad()
        {
            LBJ_Service service = new LBJ_Service();
            //List<ShiftManagementVO> Shiftlist = service.GetShiftManagement()
            //List<ShiftManagementVO> Shiftlist = service.ShiftManage();
            //dataGridView1.DataSource = service.ShiftManage();

            List<CommonCodeVO> list = new List<CommonCodeVO>();

            CommonCodeService service1 = new CommonCodeService();
            list = service1.GetAllCommonCode();

            //공통코드링큐
            List<CommonCodeVO> OrderShiftList = (from item in list
                                                 where item.Common_Type == "SHIFT"
                                                 select item).ToList();

            CommonUtil.ComboBinding(cboShift, OrderShiftList, "Common_Key", "Common_Value");
        }
        public void DataLoad2()
        {
            //List<FacilitieDetailVO> list = new List<FacilitieDetailVO>();
            List<ShiftmanageVO> list = new List<ShiftmanageVO>();
            

            LBJ_Service service1 = new LBJ_Service();

            //HSC_Service service = new HSC_Service();

            //list = service.GetAllFacilitiesDetail();
            list = service1.ShiftManage2();
            string FacName = cboSystem.Text.Trim();

            //List<FacilitieDetailVO> temp = (from item in list
            //                                where item.FAC_Name.Contains(FacName)
            //                                select item).Distinct().ToList();
            List<ShiftmanageVO> temp = (from item in list
                                        where item.FAC_Name.Contains(FacName)
                                        select item).Distinct().ToList();

            List<ShiftmanageVO> FacList = new List<ShiftmanageVO>();

            foreach (ShiftmanageVO item1 in temp)
            {
                bool addok = true;
                if (FacList.Count < 1)
                    FacList.Add(item1);
                else
                {
                    for (int i = 0; i < FacList.Count; i++)
                        if (FacList[i].FAC_Name.Trim() == item1.FAC_Name.Trim())
                            addok = false;

                    if (addok)
                        FacList.Add(item1);
                    else
                        continue;
                }
            }
            CommonUtil.ComboBinding(cboSystem, FacList, "FAC_No", "FAC_Name", "전체");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShiftManagementVO Shiftmanage = new ShiftManagementVO();
            LBJ_Service service = new LBJ_Service();

            //Shiftmanage.SHIFT_ID = Convert.ToInt32(Shiftmanage);
            Shiftmanage.FAC_Name = cboSystem.Text;
            Shiftmanage.SHIFT = cboShift.Text;
            Shiftmanage.SHIFT_StartDate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            Shiftmanage.SHIFT_EndDate = Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString());

            if (cboShift.Text == "주간")
            {
                DataSet ds = service.GetShiftManagement(Shiftmanage);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (cboShift.Text == "야간")
            {
                DataSet ds = service.GetShiftManagement(Shiftmanage);
                dataGridView1.DataSource = ds.Tables[0];
            }           
        }
      

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value.AddDays(1))
            {
                MessageBox.Show("시작일보다 빠를 수 없습니다.");
                dateTimePicker2.Value = dateTimePicker1.Value.AddDays(-7);
                return;
            }
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
