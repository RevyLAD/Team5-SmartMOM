using Project_VO.LBJ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;
using Project_VO;
using Team5_SmartMOM.BaseForm;

namespace Team5_SmartMOM.LBJ
{
    public partial class office_hours : Team5_SmartMOM.BaseGridForm
    {
        List<ShiftVO> list;

        public office_hours()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            office_hours_Insert frm = new office_hours_Insert();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void office_hours_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "SHIFT_ID", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비코드", "FAC_Code", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "Shift", "SHIFT", true, 50);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시작시간", "SHIFT_StartTime", true, 110);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "완료시간", "SHIFT_EndTime", true, 110);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "적용시작일자", "SHIFT_StartDate", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "적용완료일자", "SHIFT_EndDate", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "투입인원", "SHIFT_INPUTPeople", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "SHIFT_UserOrNot", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "SHIFT_ModifierDate", true, 130);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정시간", "SHIFT_Modifier", true, 170);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "SHIFT_Others", true, 235);

            DataLoad();
            ComboLoad();
        }
        public void DataLoad()
        {
            LBJ_Service service = new LBJ_Service();
            List<ShiftVO> Shiftlist = service.Shift();
            dataGridView1.DataSource = Shiftlist;
        }

        public void ComboLoad()
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string shift = cboShift.Text;
            string shift2 = cbosystem.Text;

            List<ShiftVO> temp = new List<ShiftVO>();

            foreach (var item in list)
            {
                if (cboShift.Text.Trim() == item.SHIFT &&
                    cbosystem.Text.Trim() == item.FAC_Code)
                {
                    temp.Add(item);
                }
            }
            dataGridView1.DataSource = temp;
        }

        private void cboShift_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
