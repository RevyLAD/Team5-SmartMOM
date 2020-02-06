using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_SmartMOM.PSM
{
    public partial class Import_Check_state : Form
    {
        public Import_Check_state()
        {
            InitializeComponent();
        }

        private void Import_Check_state_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "출발번호", "", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "검사일", "", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체명", "", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "최종결과", "", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납품수량", "", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "불량수량", "", true, 150);
            //UtilityClass.AddNewColumnToDataGridView(dataGridView1, "검사자", "", true, 150);

            DataLoad();
        }

        public void DataLoad()
        {

        }
    }
}
