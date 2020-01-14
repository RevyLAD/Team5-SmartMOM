using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public partial class ExChange_Rate_Management : Team5_SmartMOM.BaseGridForm
    {
        public ExChange_Rate_Management()
        {
            InitializeComponent();
        }

        private void ExChange_Rate_Management_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "BOM_No", true, 40);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "화폐단위","BOM_Code", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "월단위환율", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시작일자", "BOM_Require", true, 70);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "종료일자", "BOM_StartDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "BOM_EndDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "BOM_UseOrNot", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "BOM_Modifier", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정일", "BOM_ModifiyDate", true, 120);
            
        }
    }
}
