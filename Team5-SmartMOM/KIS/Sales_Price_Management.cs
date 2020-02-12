using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.KIS
{
   
    public partial class Sales_Price_Management : Team5_SmartMOM.BaseGridForm
    {
        KIS_Service service = new KIS_Service();
        public Sales_Price_Management()
        {
            InitializeComponent();
        }

        private void Btn_newitem_Click(object sender, EventArgs e)
        {
            Sales_Price_Management_detail frm = new Sales_Price_Management_detail();
           if(frm.ShowDialog() == DialogResult.OK)
            {
                DataLoad();
            }

        }

        private void Sales_Price_Management_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn(false);
            chk.Width = 40;
            chk.HeaderText = "선택";
            dataGridView1.Columns.Add(chk);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "Sales_No", false, 140);
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체", "COM_Code", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체명", "COM_Name", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true,140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 180);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_SIze", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "단위", "ITEM_Unit", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "현재단가", "Sales_Price_Now", true, 100);
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "이전단가", "Sales_Price_Previous", true, 100);
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시작일", "Sales_StartDate", true, 140);
            dataGridView1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "종료일", "Sales_EndDate", true, 140);
            dataGridView1.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "Sales_UseOrNot", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "Sales_Editer", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정일", "Sales_EditDate", true, 140);
            dataGridView1.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "Sales_Others", true, 140);
            DataLoad();
        }
        public void DataLoad()
        {
          
            List<Sales_VO_VIew> list = new List<Sales_VO_VIew>();
            list = service.ShowSales();

            dataGridView1.DataSource = list;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            List<Sales_VO_VIew> list = new List<Sales_VO_VIew>();
            string date = txt_date.Text.Replace("-","").Replace(" ","");
            string name = txt_item.Text;
            list = service.SearchSales(date , name );
            dataGridView1.DataSource = list;
        }
      
    

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            KIS_Service service = new KIS_Service();
            List<string> list = new List<string>();
            bool check = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    list.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }
            if (list.Count == 0)
            {
                MessageBox.Show("삭제할 품목을 선택해 주시기 바랍니다.");
                check = false;

            }
            else if (check)
            {
                string.Join(",", list.ToArray());
                bool bResult = service.DeleteSales(string.Join(",", list));

                if (bResult)
                {
                    MessageBox.Show("성공적으로 삭제되었습니다");
                    DataLoad();
                }
                else
                {
                    MessageBox.Show("등록중 오류가 발생하였습니다 다시 시도해주세요");
                }
            }
        }

   
    }
}
