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
using Team5_SmartMOM.BaseForm;
using Team5_SmartMOM.Service; 


namespace Team5_SmartMOM.PSM
{
    public partial class Material_Ledger_Export : Team5_SmartMOM.BaseGridForm
    {
        List<MateriaExportVO> Materialist;
        DateTimePicker dtp;
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
            DateTimePicker dtp = new DateTimePicker();
            dateTimePicker1.Value = dtp.Value;
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(7);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "작업지시서", "WO_ID", true, 120, DataGridViewContentAlignment.MiddleCenter);
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
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "출고상태", "WO_OutState", true, 120, DataGridViewContentAlignment.MiddleCenter);

            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

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
            Materialist = service.MateriaExport();
            List<FacilitieDetailVO> Facvo = hscservice.GetAllFacilitiesDetail();
            List<CommonCodeVO> Comlist = new List<CommonCodeVO>();

            List<MateriaExportVO> MateriaEVO = (from item in Materialist
                                                where
                                               item.WO_OutState == "출고대기"
                                                select item).ToList();


            dataGridView1.DataSource = list = MateriaEVO;

            CommonCodeService service1 = new CommonCodeService();
            Comlist = service1.GetAllCommonCode();

            List<CommonCodeVO> CommonState = (from item in Comlist
                                              where item.Common_Type == "OUT_STATE"
                                              select item).ToList();

            CommonUtil.ComboBinding(comboBox3, CommonState, "Common_Key", "Common_Value");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            LBJ_Service service = new LBJ_Service();

            bool bFlag = false;
            bool bFlag2 = true;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells["Check"].EditedFormattedValue)
                {
                    if (dataGridView1.Rows[i].Cells[12].Value.ToString() == "출고완료")
                    {
                        bFlag2 = false;
                    }
                    bFlag = true;
                    break;
                }
            }

            if (bFlag == false)
            {
                MessageBox.Show("출고하실 항목을 선택해주세요.", "출고 실패", MessageBoxButtons.OK);
                return;
            }
            if (bFlag2 == false)
            {
                MessageBox.Show("출고완료된 제품이 있습니다.");
                return;
            }


            List<MateriaExportOkVO> mevo = new List<MateriaExportOkVO>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool CellChecked = Convert.ToBoolean(row.Cells["Check"].EditedFormattedValue);

                if (CellChecked)
                {
                    MateriaExportOkVO iollist = new MateriaExportOkVO();
                    iollist.WO_ID = row.Cells[1].Value.ToString();
                    iollist.directQty = Convert.ToInt32(row.Cells[11].Value);
                    iollist.In_WareHouse = row.Cells[8].Value.ToString();
                    iollist.InOut_Date = (DateTime)row.Cells[2].Value;
                    iollist.From_WareHouse = row.Cells[7].Value.ToString();
                    iollist.ITEM_Code = row.Cells[3].Value.ToString();
                    iollist.InOut_Qty = Convert.ToInt32(row.Cells[10].Value);
                    mevo.Add(iollist);

                }
            }
            LBJ_Service lbjservice = new LBJ_Service();


            if (MessageBox.Show("출고하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lbjservice.MateriaTran(mevo))
                {
                    MessageBox.Show("출고 성공", "성공", MessageBoxButtons.OK);
                    DataLoad();
                }
                else
                {
                    MessageBox.Show("출고 실패", "성공", MessageBoxButtons.OK);
                    DataLoad();
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<MateriaExportVO> Exportlist = (from item in Materialist
                               where item.WO_StartDate > dateTimePicker1.Value &&
                                              item.WO_StartDate <= dateTimePicker2.Value &&
                                              item.WO_OutState == comboBox3.Text
                               select item).ToList();
            dataGridView1.DataSource = Exportlist;


        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //if (dateTimePicker1.Value > dateTimePicker2.Value)
            //{
            //    MessageBox.Show("시작일보다 빠를 수 없습니다.");
            //    dateTimePicker2.Value = dtp.Value.AddMonths(6);
            //    return;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            int i, j;

            saveFileDialog1.Filter = "Excel Files (*.xls)|*.xls";
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add();
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Cells[1, 2] = "작업지시서";
                xlWorkSheet.Cells[1, 3] = "요청일";
                xlWorkSheet.Cells[1, 4] = "품목";
                xlWorkSheet.Cells[1, 5] = "품명";
                xlWorkSheet.Cells[1, 6] = "규격";
                xlWorkSheet.Cells[1, 7] = "품목유형";
                xlWorkSheet.Cells[1, 8] = "요청창고";
                xlWorkSheet.Cells[1, 9] = "불출창고";
                xlWorkSheet.Cells[1, 10] = "현재고";
                xlWorkSheet.Cells[1, 11] = "계획수량";
                xlWorkSheet.Cells[1, 12] = "요청수량";
                xlWorkSheet.Cells[1, 13] = "출고상태";

                for (i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (j = 0; j < dataGridView1.ColumnCount - 1; j++)
                    {
                        if (dataGridView1[j, i].Value != null)
                            xlWorkSheet.Cells[i + 2, j + 1] = dataGridView1[j, i].Value.ToString();
                    }
                }

                xlWorkBook.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close(true);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
