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
        CheckBox headerCheckBox = new CheckBox();
        List<InOutListVO> iol;
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

            chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "Check";
            chk.Width = 30;
            dataGridView1.Columns.Add(chk);

            Point headerLocation = dataGridView1.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox.Location = new Point(headerLocation.X + 8, headerLocation.Y + 6);
            headerCheckBox.BackColor = Color.FromArgb(55, 113, 138);
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += new EventHandler(HeaderCheckBox_Click);
            dataGridView1.Controls.Add(headerCheckBox);

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

            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

            //LBJ_Service service = new LBJ_Service();
            //dataGridView1.DataSource = service.MateriaExport();
            DataLoad();
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool isChecked = true;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue) == false)
                    {
                        isChecked = false;
                        break;
                    }
                }
                headerCheckBox.Checked = isChecked;
            }
        }
        private void DataLoad()
        {
            LBJ_Service service = new LBJ_Service();
            HSC_Service hscservice = new HSC_Service();
            List<MateriaExportVO> Materialist = service.MateriaExport();
            List<FacilitieDetailVO> Facvo = hscservice.GetAllFacilitiesDetail();
            dataGridView1.DataSource = list = Materialist;           

            CommonUtil.ComboBinding(comboBox1, Facvo, "FAC_No", "FAC_Name", "전체");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            LBJ_Service service = new LBJ_Service();
            List<string> list = new List<string>();

            bool bFlag = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells["Check"].EditedFormattedValue)
                {
                    bFlag = true;
                    break;
                }
            }
            if (bFlag == false)
            {
                MessageBox.Show("출고하실 항목을 선택해주세요.", "출고 실패", MessageBoxButtons.OK);
                return;
            }
            List<MateriaExportVO> mevo = new List<MateriaExportVO>();
            List<InOutListVO> iol = new List<InOutListVO>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool CellChecked = Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue);

                if (CellChecked)
                {
                    InOutListVO iollist = new InOutListVO();
                    iollist.InOut_Date = (DateTime)row.Cells[2].Value;
                    iollist.From_WareHouse = row.Cells[7].Value.ToString();
                    iollist.ITEM_Code = row.Cells[3].Value.ToString();
                    iollist.InOut_Qty = Convert.ToInt32(row.Cells[10].Value);
                    iol.Add(iollist);

                }
            }
            LBJ_Service lbjservice = new LBJ_Service();
            lbjservice.MateriaTran(mevo, iol);
            if (MessageBox.Show("출고하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("출고 성공", "성공", MessageBoxButtons.OK);
                DataLoad();
            }
            else { }                
        }
    }
}
