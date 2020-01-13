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
    public partial class FacilitiesDetail : BaseGridForm
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
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비명", "FAC_Name", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소진창고", "FAC_OutWareHouse", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "양품창고", "FAC_InWareHouse", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "불량창고", "FAC_BadWareHouse", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "FAC_UseOrNot", true, 95);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "FAC_Modifier", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정일", "FAC_ModifiyDate", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "특이사항", "FAC_Remark", true, 60);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "FAC_Others", true, 107);

            HSC_Service service = new HSC_Service();
            dataGridView1.DataSource = service.GetAllFacilitiesDetail();
        }
    }
}
