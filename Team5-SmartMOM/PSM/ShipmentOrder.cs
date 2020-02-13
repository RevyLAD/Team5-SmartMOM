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
    public partial class ShipmentOrder : Form
    {
        List<ShipmentOrderVO> list;
        List<DeadLineVO> list2;
        CheckBox headerCheckBox = new CheckBox();
        CheckBox headerCheckBox2 = new CheckBox();
        public ShipmentOrder()
        {
            InitializeComponent();
        }

        private void ShipmentOrder_Load(object sender, EventArgs e)
        {
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

            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "고객주문번호", "SO_WorkOrderID", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "납기일", "SALES_Duedate", true, 120, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "PO NO", "", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "출발처리번호", "", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "고객사코드", "COM_Code", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "고객사", "COM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "도착지코드", "COM_Code", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "도착지", "COM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "고객사품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품명", "ITEM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "주문수량", "SALES_OrderQty", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "출하수량", "SALES_OrderQty", true, 100, DataGridViewContentAlignment.MiddleRight);


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

            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "고객주문번호", "SO_WorkOrderID", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "PO NO", "", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "출발처리번호", "", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "고객사코드", "COM_Code", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "도착지명", "COM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "고객사품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "품명", "ITEM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "주문수량", "SALES_OrderQty", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "출하수량", "SALES_OrderQty", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "매출확정수량", "SALES_OrderQty", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "매출확정금액", "Price", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView3, "마감일자", "", true, 100, DataGridViewContentAlignment.MiddleCenter);


            DataLoad();
            Datagridview();
        }

        public void DataLoad()
        {
            PSM_Service service = new PSM_Service();

            List<PlanIDVO> planid = service.PlanID2();
            CommonUtil.ComboBinding(cboplanid, planid, "Plan_ID", "Plan_ID");

            List<CompanyCodeVO> company = service.GetAllCompanyCode2();
            CommonUtil.ComboBinding(cbocompany, company, "COM_Code", "COM_Name", "");

            ShipmentOrderSearchVO so = new ShipmentOrderSearchVO();
            so.Company = cbocompany.Text.Trim();
            so.Item = txtitem.Text.Trim();
            so.Plan_ID = cboplanid.Text.Trim();


            list = service.ShipmentOrder(so);
            dataGridView2.DataSource = list;

            list2 = service.DeadLine();
            dataGridView3.DataSource = list2;


        }

        public void Datagridview()
        {
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

        private void btnshipment_OK_Click(object sender, EventArgs e)
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
                MessageBox.Show("출하하실 제품을 선택하십시오.");
                return;
            }

            List<ShipmentVO> lists = new List<ShipmentVO>();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                bool isCellChecked = Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue);

                if (isCellChecked)
                {
                    ShipmentVO list = new ShipmentVO();
                    list.SO_WorkOrderID = row.Cells[1].Value.ToString();
                    lists.Add(list);
                }
            }
            PSM_Service service = new PSM_Service();
            service.Shipment(lists);

            DataLoad();
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
                MessageBox.Show("마감처리할 항목을 체크하세요");
                return;
            }
            List<DeadLinePutVO> lists = new List<DeadLinePutVO>();
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                bool isCellChecked = Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue);

                if (isCellChecked)
                {
                    DeadLinePutVO list = new DeadLinePutVO();
                    list.SO_WorkOrderID = row.Cells[1].Value.ToString();
                    lists.Add(list);
                }
            }
            PSM_Service service = new PSM_Service();
            service.DeaLinePut(lists);

            DataLoad();

        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int j = 0; j < dataGridView3.RowCount; j++)
            {

                dataGridView3[11, j].Style.BackColor = Color.SkyBlue;
                dataGridView3[12, j].Style.BackColor = Color.SkyBlue;

            }
        }
    }
}
