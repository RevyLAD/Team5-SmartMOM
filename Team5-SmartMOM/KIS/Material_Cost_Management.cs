using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

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
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Width = 40;
            chk.HeaderText = "선택";
            dataGridView1.Columns.Add(chk);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "Material_No", false, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체", "COM_Code", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체명", "COM_Name", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 70);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_SIze", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "단위", "ITEM_Unit", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "현재단가", "Material_Price_Now", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "이전단가", "Material_Price_Previous", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시작일", "Material_StartDate", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "종료일", "Material_EndDate", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "Material_UseOrNot", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "Material_Editer", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정일", "Material_EditDate", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "Material_Others", true, 140);
            DataLoad();
        }

        public void DataLoad()
        {
            KIS_Service service = new KIS_Service();
            List<Material_VO_VIew> list = new List<Material_VO_VIew>();
            list = service.ShowMaterial();

            dataGridView1.DataSource = list;
        }
    }
}
