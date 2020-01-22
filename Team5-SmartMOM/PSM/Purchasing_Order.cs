using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.PSM
{
    public partial class Purchasing_Order : Form
    {
        List<PurchasingVO> list;
        public Purchasing_Order()
        {
            InitializeComponent();
        }       

        private void Purchasing_Order_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체번호", "COM_No", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체이름", "COM_Name", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체코드", "COM_Code", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주업체", "ITEM_OrderComp ", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주수량", "Vo_Quantity ", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "최소발주수량", "ITEM_MinOrderQuantity  ", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "Vo_EndDate", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수입검사여부", "ITEM_ImportIns ", false, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", false, 150);

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "업체이름", "COM_Name", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "업체코드", "COM_Code", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "발주업체", "ITEM_OrderComp ", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "발주수량", "Vo_Quantity ", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "최소발주수량", "ITEM_MinOrderQuantity  ", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "납기일", "Vo_EndDate", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "수입검사여부", "ITEM_ImportIns ", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "규격", "ITEM_Size", true, 100);

            DataLoad();
        }

        public void DataLoad()
        {
            //string id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();            
            PSM_Service service = new PSM_Service();
            list = service.GetAllPurChasing();
            dataGridView1.DataSource = list;
            dataGridView2.DataSource = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
