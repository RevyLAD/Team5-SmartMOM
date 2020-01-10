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
    public partial class FacilitiesDetail : Team5_SmartMOM.Facilities
    {
        public FacilitiesDetail()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FacilitiesRegister frm = new FacilitiesRegister();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void FacilitiesDetail_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "번호", "FAC_No", true, 70);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비군 코드", "FACG_Code", true, 105);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비 코드", "FAC_Code", true, 105);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "밖 창고", "FAC_OutWareHouse", true, 85);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "안 창고", "FAC_InWareHouse", true, 85);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "못된창고", "FAC_BadWareHouse", true, 95);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "FAC_UseOrNot", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "모디", "FAC_Modifier", true, 60);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "모디일", "FAC_ModifiyDate", true, 70);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "리맠", "FAC_Remark", true, 60);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "다른거", "FAC_Others", true, 107);

            HSC_Service service = new HSC_Service();
            dataGridView1.DataSource = service.GetAllFacilitiesDetail();
        }
    }
}
