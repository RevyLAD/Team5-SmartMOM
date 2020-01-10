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
    public partial class Purchasing_State : BaseGridForm
    {
        List<PurchasingStateVO> list;
        public Purchasing_State()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Purchasing_State_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주번호", "VO_ID", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체코드", "COM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체이름", "COM_Name", true, 150);            
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주상태", "MATERIAL_ORDER_STATE", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목번호", "ITEM_No", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code  ", true, 180);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size  ", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "단위", "ITEM_Unit   ", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "VO_EndDate ", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주량", "VO_Quantity ", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "발주일", "VO_StartDate ", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "입고일", "VO_InDate ", true, 150);


        }

        public void DataLoad()
        {            
            PSM_Service service = new PSM_Service();
            list = service.GetAllPurChasingState();
            dataGridView1.DataSource = list;
            
        }
    }
}
