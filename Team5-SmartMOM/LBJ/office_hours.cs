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

namespace Team5_SmartMOM.LBJ
{
    public partial class office_hours : Team5_SmartMOM.BaseGridForm
    {

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
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "Shift", "SHIFT", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시작시간", "SHIFT_StartTime", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "완료시간", "SHIFT_EndTime", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "적용시작일자", "SHIFT_StartDate", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "적용완료일자", "SHIFT_EndDate", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "투입인원", "SHIFT_INPUTPeople", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "SHIFT_UserOrNot", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "SHIFT_Modifier", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정시간", "SHIFT_ModifierDate", true, 145);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "SHIFT_Others", true, 160);

            DataLoad();
        }
        public void DataLoad()
        {
            LBJ_Service service = new LBJ_Service();
            List<ShiftVO> Shiftlist = service.Shift();
            dataGridView1.DataSource = Shiftlist;


            List<ShiftListVO> list = new List<ShiftListVO>();
            list = service.ShiftListVO();
            cboShift.DataSource = list;
            cboShift.DisplayMember = "SHIFT";
            cboShift.ValueMember = "SHIFT_ID";
        }
    }
}
