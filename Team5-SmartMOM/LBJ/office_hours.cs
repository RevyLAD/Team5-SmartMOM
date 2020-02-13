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
using Project_VO;
using Team5_SmartMOM.BaseForm;

namespace Team5_SmartMOM.LBJ
{
    public partial class office_hours : Team5_SmartMOM.BaseGridForm
    {
        List<ShiftVO> list;
        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
        public office_hours()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            office_hours_Insert frm = new office_hours_Insert();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LBJ_Service service = new LBJ_Service();
                dataGridView1.DataSource = list = service.Shift();
            }           
        }

        private void office_hours_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            
            chk.Width = 40;
            chk.HeaderText = "선택";
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "SHIFT_ID", true, 100, DataGridViewContentAlignment.MiddleRight);
            dataGridView1.Columns.Add(chk);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비명", "FAC_Name", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비코드", "FAC_Code", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "Shift", "SHIFT", true, 50, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "시작시간", "SHIFT_StartTime", true, 110,DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "완료시간", "SHIFT_EndTime", true, 110, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "적용시작일자", "SHIFT_StartDate", true, 160, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "적용완료일자", "SHIFT_EndDate", true, 160, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "투입인원", "SHIFT_INPUTPeople", true, 140, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "SHIFT_UserOrNot", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정자", "SHIFT_ModifierDate", true, 130);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수정시간", "SHIFT_Modifier", true, 170, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "SHIFT_Others", true, 235);

            LBJ_Service service = new LBJ_Service();
            dataGridView1.DataSource = list = service.Shift();
            DataLoad();
            ComboLoad();
        }      
        public void DataLoad()
        {
            dataGridView1.DataSource = null;
            LBJ_Service service = new LBJ_Service();
            List<ShiftVO> Shiftlist = service.Shift();
            dataGridView1.DataSource = Shiftlist;

            List<CommonCodeVO> list1 = new List<CommonCodeVO>();

            CommonCodeService service1 = new CommonCodeService();
            list1 = service1.GetAllCommonCode();

            //공통코드링큐
            List<CommonCodeVO> OrderShiftList = (from item in list1
                                                 where item.Common_Type == "SHIFT"
                                                 select item).ToList();

            CommonUtil.ComboBinding(cboShift, OrderShiftList, "Common_Key", "Common_Value" ,"전체");

            //if (cboShift.Text.Trim() == "전체" && cbosystem.Text.Trim() == "전체")
            //{
            //    dataGridView1.DataSource = list1;
            //}
        }

        public void ComboLoad()
        {
            List<FacilitieDetailVO> list = new List<FacilitieDetailVO>();

            HSC_Service service = new HSC_Service();

            list = service.GetAllFacilitiesDetail();
            string FacCode = cbosystem.Text.Trim();

            List<FacilitieDetailVO> temp = (from item in list
                                           where item.FAC_Code.Contains(FacCode)
                                           select item).Distinct().ToList();



            List<FacilitieDetailVO> FacList = new List<FacilitieDetailVO>();

            foreach (FacilitieDetailVO item1 in temp)
            {
                bool addok = true;
                if (FacList.Count < 1)
                    FacList.Add(item1);
                else
                {
                    for (int i = 0; i < FacList.Count; i++)
                        if (FacList[i].FAC_Code.Trim() == item1.FAC_Code.Trim())
                            addok = false;

                    if (addok)
                        FacList.Add(item1);
                    else
                        continue;
                }
            }
            CommonUtil.ComboBinding(cbosystem, FacList, "FAC_No", "FAC_Code", "전체");

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ShiftVO> list = new List<ShiftVO>();

            if (cboShift.Text.Trim() == "" && cbosystem.Text.Trim() == "")
            {
                
            }
            else 
            {
                dataGridView1.DataSource = ShiftSearch();
            }
            //if (cbosystem.Text.Trim() == "전체")
            //{
            //    string system = cbosystem.Text.Trim();
            //    list = null;
            //    list = (from item in list
            //            where item.FAC_Code.Contains(system)
            //            select item).ToList();
            //    dataGridView1.DataSource = list;
            //}
            //else
            //    DataLoad();
                
        }
        private List<ShiftVO> ShiftSearch()
        {
            list = new List<ShiftVO>();

            foreach (var item in list)
            {
                if (item.SHIFT.Trim().Contains(cboShift.Text.Trim()) &&
                        item.FAC_Code.Trim().Contains(cbosystem.Text.Trim()))
                    list.Add(item);
            }
            return list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LBJ_Service service = new LBJ_Service();
            List<string> list = new List<string>();
            bool check = true;
            
            for (int i=0; i<dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[1].Value) == true)
                {
                    list.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                }
            }
            if (list.Count == 0)
            {
                MessageBox.Show("삭제할 품목을 선택해 주세요.", "삭제 실패", MessageBoxButtons.OK);
                check = false;
            }
            else if (check)
            {

                bool bResult = service.DeleteShift(string.Join(",", list));

                if (MessageBox.Show("삭제하시겠습니까?","YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("삭제 성공", "성공", MessageBoxButtons.OK);
                    DataLoad();
                }
                else { }                         
            }
        }

        private void cbosystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbosystem.Text != "")
                {
                    string FacCode = cbosystem.Text;

                    if (FacCode == "전체")
                    {
                        dataGridView1.DataSource = list;
                    }
                    else
                    {
                        List<ShiftVO> searchlist = null;
                        searchlist = (from item in list
                                      where item.FAC_Code.ToString().Contains(FacCode)
                                      select item).ToList();

                        dataGridView1.DataSource = searchlist;
                    }
                }
                else
                {
                    DataLoad();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
