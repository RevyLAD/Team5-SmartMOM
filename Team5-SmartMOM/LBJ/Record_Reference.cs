using Project_VO.LBJ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.LBJ
{
    public partial class Record_Reference : Team5_SmartMOM.BaseOnlyGridForm
    {
        List<StockStateVO> stockVO;
        public Record_Reference()
        {
            InitializeComponent();
        }

        private void Record_Reference_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dgvMain, "No", "InOut_No", true, 50, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dgvMain, "입출고일", "InOut_Date", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dgvMain, "구분", "InOut_Gubun", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dgvMain, "카테고리", "InOut_Category", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dgvMain, "From창고", "From_WareHouse", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dgvMain, "창고", "In_WareHouse", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dgvMain, "품목", "ITEM_Code", true, 200, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dgvMain, "품명", "ITEM_Name", true, 200, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dgvMain, "규격", "ITEM_Size", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dgvMain, "품목형태", "ITEM_Type", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dgvMain, "수불량", "InOut_Qty", true, 100, DataGridViewContentAlignment.MiddleRight);
            DataLoad();
        }
        public void DataLoad()
        {
            LBJ_Service service = new LBJ_Service();
            List<StockStateVO> Stock = service.StockState();
            dgvMain.DataSource = stockVO = Stock;
        }
    }
}
