using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public partial class Material_Cost_Management : Team5_SmartMOM.BaseGridForm
    {
        public Material_Cost_Management()
        {
            InitializeComponent();
        }

        private void Btn_newitem_Click(object sender, EventArgs e)
        {
            Material_Cost_Management_detail frm = new Material_Cost_Management_detail();
            frm.ShowDialog();
        }

        private void Material_Cost_Management_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "BOM_No", true, 40);
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Width = 40;
            chk.HeaderText = "선택";
            dataGridView1.Columns.Add(chk);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체", "BOM_Code", true, 140);

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "BOM_Require", true, 70);
          
        
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "Market", "BOM_Modifier", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "환종", "BOM_ModifiyDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "현재단가", "BOM_AutoDeduction", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "이전단가", "BOM_RequirePlan", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시작일", "BOM_Others", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "종료일", "BOM_Others", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "BOM_Others", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "BOM_Others", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정일", "BOM_Others", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "BOM_Others", true, 140);

        }
    }
}
