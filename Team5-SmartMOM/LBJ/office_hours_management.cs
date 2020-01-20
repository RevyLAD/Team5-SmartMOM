using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.LBJ
{
    public partial class office_hours_management : Team5_SmartMOM.BaseGridForm
    {
        public office_hours_management()
        {
            InitializeComponent();
        }

        DateTimePicker dtp;
        private void office_hours_management_Load(object sender, EventArgs e)
        {
            //설비명 쉬프트 구분 날짜날짜날짜날짜
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "SHIFT_ID", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비명", "FAC_Name", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "구분", "", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시작", "SHIFT_StartTime", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "종료", "SHIFT_EndTime", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "인원", "SHIFT_InputPeople", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "날짜", "", true, 120);


            dtp = new DateTimePicker();
            dateTimePicker1.Value = dtp.Value = DateTime.Now.AddDays(-7);
            DataLoad();
        }
        public void DataLoad()
        {
            LBJ_Service service = new LBJ_Service();
            dataGridView1.DataSource = service.ShiftManage();
        }
    }
}
