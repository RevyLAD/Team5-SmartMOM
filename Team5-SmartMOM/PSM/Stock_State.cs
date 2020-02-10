using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.PSM
{
    public partial class Stock_State : Team5_SmartMOM.BaseGridForm
    {
        CheckBox headerCheckBox = new CheckBox();
        List<Stock_StateVO> list = new List<Stock_StateVO>();
        public Stock_State()
        {
            InitializeComponent();
        }

        private void Stock_State_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "Check";
            chk.Width = 30;
            dataGridView1.Columns.Add(chk);

            Point headerLocation = dataGridView1.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox.Location = new Point(headerLocation.X + 8, headerLocation.Y + 6);
            headerCheckBox.BackColor = Color.White;
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += new EventHandler(HeaderCheckBox_Click);
            dataGridView1.Controls.Add(headerCheckBox);

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "창고코드", "FACT_Code", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "창고", "FACT_Name", true, 90);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목타입", "ITEM_Type", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "재고량", "FACD_Qty", true, 150);            
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "단위", "ITEM_Unit", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "관리등급", "", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "", true, 150);


            DataLoad();
        }

        public void DataLoad()
        {
            PSM_Service service = new PSM_Service();
            list = service.Stock_State();
            dataGridView1.DataSource = list;
        }

            private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox.Checked;
            }
        }
    }
}
