using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.HSC
{
    public partial class FactoryManager : Team5_SmartMOM.BaseGridForm
    {
        public FactoryManager()
        {
            InitializeComponent();
        }

        private void FactoryManager_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "번호", "FACT_No", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시설군", "FACT_Group", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시설구분", "FACT_Class", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "타입", "FACT_Type", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "코드", "FACT_Code", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "공장명", "FACT_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "상위시설", "FACT_Parent", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "자재차감", "FACT_MATDeduction", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "FACT_UseOrNot", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "FACT_Modifier", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정일", "FACT_ModifyDate", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설명", "FACT_Information", true, 258);

            Factory_DataLoad();
        }


        private void Factory_DataLoad()
        {
            HSC_Service service = new HSC_Service();
            dataGridView1.DataSource = service.GetAllFactory();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            FactoryRegister frm = new FactoryRegister();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
