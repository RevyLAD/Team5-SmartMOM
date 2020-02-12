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
    public partial class Material_Cost_Management : Team5_SmartMOM.BaseGridForm
    {
        List<Material_VO_VIew> list;
        KIS_Service service = new KIS_Service();
        public Material_Cost_Management()
        {
            InitializeComponent();
        }

        private void Btn_newitem_Click(object sender, EventArgs e)
        {
            Material_Cost_Management_detail frm = new Material_Cost_Management_detail();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataLoad();
            }
            
        }

        private void Material_Cost_Management_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn(false);
            chk.Width = 40;
            chk.HeaderText = "선택";
            dataGridView1.Columns.Add(chk);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "Material_No", false, 140);
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체", "COM_Code", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체명", "COM_Name", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_SIze", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "단위", "ITEM_Unit", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "현재단가", "Material_Price_Now", true, 100);
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "이전단가", "Material_Price_Previous", true, 100);
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시작일", "Material_StartDate", true, 140);
            dataGridView1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "종료일", "Material_EndDate", true, 140);
            dataGridView1.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "Material_UseOrNot", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "Material_Editer", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정일", "Material_EditDate", true, 140);
            dataGridView1.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "Material_Others", true, 140);
            DataLoad();
        }

        public void DataLoad()
        {
            KIS_Service service = new KIS_Service();
            list = service.ShowMaterial();

            dataGridView1.DataSource = list;
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            List<Material_VO_VIew> list = new List<Material_VO_VIew>();
            string date = dtp_ExistingDate.Text.Replace("-", "").Replace(" ", "");
            string name = txt_item.Text;
            list = service.SearchMaterial(date, name);
            dataGridView1.DataSource = list;
        }

        private void Btn_delete_Click(object sender, EventArgs e)
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
                bool bResult = service.DeleteMaterial(string.Join(",", list));

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
