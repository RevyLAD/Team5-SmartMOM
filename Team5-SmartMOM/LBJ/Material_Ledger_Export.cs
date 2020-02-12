using Project_VO;
using Project_VO.LBJ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.PSM
{
    public partial class Material_Ledger_Export : Team5_SmartMOM.BaseGridForm
    {
        List<MateriaExportVO> mevo;
        List<InoutList> iol;
        List<MateriaExportVO> list;
        DataGridViewCheckBoxColumn chk;
        public Material_Ledger_Export()
        {
            InitializeComponent();
        }

        private void Material_Ledger_Export_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Width = 40;
            chk.HeaderText = "선택";
            dataGridView1.Columns.Add(chk);

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "작업지시서", "WO_ID", true, 120,DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "요청일", "WO_StartDate", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "FAC_Name", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목유형", "ITEM_Type", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "요청창고", "FACT_Name", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "불출창고", "FACT_Name1", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "현재고", "FACD_Qty", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "계획수량", "planQty", true, 120, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "요청수량", "directQty", true, 120, DataGridViewContentAlignment.MiddleRight);

            LBJ_Service service = new LBJ_Service();
            dataGridView1.DataSource = service.MateriaExport();
            DataLoad();
        }
        private void DataLoad()
        {
            LBJ_Service service = new LBJ_Service();
            HSC_Service hscservice = new HSC_Service();
            List<MateriaExportVO> Materialist = service.MateriaExport();
            List<FacilitieDetailVO> Facvo = hscservice.GetAllFacilitiesDetail();
            dataGridView1.DataSource = Materialist;           

            CommonUtil.ComboBinding(comboBox1, Facvo, "FAC_No", "FAC_Name", "전체");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            LBJ_Service service = new LBJ_Service();
            List<string> list = new List<string>();
            bool check = true;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    list.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                }
            }
            if (list.Count == 0)
            {
                MessageBox.Show("출고할 품목을 선택하세요.", "출고 실패", MessageBoxButtons.OK);
            }
            else if (check)
            {
                bool bResult = service.MateriaTran(mevo, iol);

                if (MessageBox.Show("해당 품목을 출고 하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    MessageBox.Show("출고 성공", "성공", MessageBoxButtons.OK);
                    DataLoad();
                }
                else { }
            }


        }
    }
}
