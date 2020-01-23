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
    public partial class BOM : Team5_SmartMOM.BaseGridForm
    {
        public BOM()
        {
            InitializeComponent();
            LoadPage();
        }

       

        private void Btn_newitem_Click_1(object sender, EventArgs e)
        {
            BOM_detail frm = new BOM_detail();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataLoad();
            }
        }

        private void BOM_Load(object sender, EventArgs e)
        {
            LoadPage();
        }

        private void LoadPage()
        {
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;


            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Width = 40;
            chk.HeaderText = "선택";
            
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "BOM_No", true, 40);
            dataGridView1.Columns.Add(chk);
       
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "상위품목", "BOM_Code", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소요량", "BOM_Require", true, 70);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시작일", "BOM_StartDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "종료일", "BOM_EndDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "BOM_UseOrNot", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "BOM_Modifier", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정시간", "BOM_ModifiyDate", true, 120);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "자동차감", "BOM_AutoDeduction", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소요계획", "BOM_RequirePlan", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "BOM_Others", true, 140);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataLoad();

        }

        public void DataLoad()
        {
            KIS_Service service = new KIS_Service();
            dataGridView1.DataSource = service.ShowBOM();
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex > -1) && dataGridView1.Columns[1] is DataGridViewCheckBoxColumn )
            {
             
            }
        }
    }
}
