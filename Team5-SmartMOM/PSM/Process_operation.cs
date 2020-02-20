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
    public partial class Process_operation : Form
    {
        CheckBox headerCheckBox = new CheckBox();
        CheckBox headerCheckBox2 = new CheckBox();
        List<Process_operationVO> list = new List<Process_operationVO>();
        List<Process_operation_finishVO> list2 = new List<Process_operation_finishVO>();
        
        public Process_operation()
        {
            InitializeComponent();
        }

        private void Process_operation_Load(object sender, EventArgs e)
        {
            dtpDateStart.Value = DateTime.Now;
            dtpDateEnd.Value = dtpDateStart.Value.AddMonths(1);
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "Check";
            chk.Width = 30;
            dataGridView2.Columns.Add(chk);

            Point headerLocation = dataGridView2.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox.Location = new Point(headerLocation.X + 8, headerLocation.Y + 6);
            headerCheckBox.BackColor = Color.FromArgb(55, 113, 138);
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += new EventHandler(HeaderCheckBox_Click);
            dataGridView2.Controls.Add(headerCheckBox);
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "지시일", "WO_StartDate", true, 200, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "설비ID", "FAC_Code", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "설비명", "FAC_Name", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "우선순위", "", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목", "ITEM_Code", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품명", "ITEM_Name", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "상태", "WO_State", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "양품창고", "FAC_OutWareHouse", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "불량창고", "", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "지시량", "planQty", true, 100, DataGridViewContentAlignment.MiddleRight);            
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "양품수량", "WO_GoodQty", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "불량수량", "WO_BadQty", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "잔량", "restQty", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "WO_ID", "WO_ID", true, 100, DataGridViewContentAlignment.MiddleRight);

            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewCheckBoxColumn chk2 = new DataGridViewCheckBoxColumn();
            chk2.HeaderText = "";
            chk2.Name = "Check";
            chk2.Width = 30;
            dataGridView3.Columns.Add(chk2);

            Point headerLocation2 = dataGridView3.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox2.Location = new Point(headerLocation2.X + 8, headerLocation2.Y + 6);
            headerCheckBox2.BackColor = Color.FromArgb(55, 113, 138);
            headerCheckBox2.Size = new Size(18, 18);
            headerCheckBox2.Click += new EventHandler(HeaderCheckBox_Click2);
            dataGridView3.Controls.Add(headerCheckBox2);
            dataGridView3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;          

            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "품목", "ITEM_Code", true, 250, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "품명", "ITEM_Name", true, 250);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "규격", "ITEM_Size", true, 250);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "현재고", "FACD_Qty", true, 150, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "이동창고", "FACT_Name", true, 150, DataGridViewContentAlignment.MiddleCenter);            
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "이동수량", "WO_GoodQty", true, 150, DataGridViewContentAlignment.MiddleRight);            
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "비고", "", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "WO_ID", "WO_ID", true, 200);

            Dataload();
            Datagridview();
        }
        public void Dataload()
        {
            OPSearchVO op = new OPSearchVO();
            op.startDate = dtpDateStart.Value.ToString("yyyy-MM-dd");
            op.endDate = dtpDateEnd.Value.ToString("yyyy-MM-dd");

            PSM_Service service = new PSM_Service();
            list = service.Process_operation(op);
            dataGridView2.DataSource = list;            

            list2 = service.Process_operation_finish();
            dataGridView3.DataSource = list2;
        }

        public void Datagridview()
        {
            dtpDateStart.Value = DateTime.Now;
            dtpDateEnd.Value = DateTime.Now.AddMonths(1);
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 113, 138);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersHeight = 30;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 113, 138);
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView3.ColumnHeadersHeight = 30;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        }

        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox.Checked;
            }
        }

        private void HeaderCheckBox_Click2(object sender, EventArgs e)
        {
            dataGridView3.EndEdit();
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["Check"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox2.Checked;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool bFlag = false;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if ((bool)dataGridView2.Rows[i].Cells["Check"].EditedFormattedValue)
                {
                    bFlag = true;
                    break;
                }
            }
            if (bFlag == false)
            {
                MessageBox.Show("항목을 체크하세요");
                return;
            }

            List<WO_IDVO> lists = new List<WO_IDVO>();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                bool isCellChecked = Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue);

                if (isCellChecked)
                {
                    WO_IDVO list = new WO_IDVO();
                    list.WO_ID = row.Cells[14].Value.ToString();
                    lists.Add(list);
                }
            }
            PSM_Service service = new PSM_Service();
            service.OP_StateChange(lists);

            Dataload();
        }

        private void btnDeadLine_OK_Click(object sender, EventArgs e)
        {
            bool bFlag = false;
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                if ((bool)dataGridView3.Rows[i].Cells["Check"].EditedFormattedValue)
                {
                    bFlag = true;
                    break;
                }
            }
            if (bFlag == false)
            {
                MessageBox.Show("항목을 체크하세요");
                return;
            }

            List<WO_IDVO> lists = new List<WO_IDVO>();
            List<ProductADDVO> lists2 = new List<ProductADDVO>();
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                bool isCellChecked = Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue);

                if (isCellChecked)
                {
                    WO_IDVO list = new WO_IDVO();
                    list.WO_ID = row.Cells[8].Value.ToString();
                    lists.Add(list);

                    ProductADDVO list2 = new ProductADDVO();
                    list2.ITEM_Code = row.Cells[1].Value.ToString();
                    list2.FACT_Name = row.Cells[5].Value.ToString();
                    list2.WO_GoodQty = Convert.ToInt32(row.Cells[6].Value);
                    lists2.Add(list2);
                }
            }

            PSM_Service service = new PSM_Service();
            service.OP_StateChange2(lists, lists2);
            MessageBox.Show("공정이동이 완료되었습니다.");
            Dataload();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OPSearchVO op = new OPSearchVO();
            op.startDate = dtpDateStart.Value.ToString("yyyy-MM-dd");
            op.endDate = dtpDateEnd.Value.ToString("yyyy-MM-dd");

            PSM_Service service = new PSM_Service();
            list = service.Process_operation(op);
            dataGridView2.DataSource = list;
        }
    }
}
