using Project_VO;
using Project_VO.LBJ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.BaseForm;
using Team5_SmartMOM.LBJ;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.PSM
{
    public partial class Stock_RF_State : Team5_SmartMOM.BaseGridForm
    {
        List<StockStateVO> stockVO;
        public Stock_RF_State()
        {
            InitializeComponent();
        }

        private void Stock_RF_State_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "InOut_No", true, 50, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "입출고일", "InOut_Date", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "구분", "InOut_Gubun", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "카테고리", "InOut_Category", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "From창고", "From_WareHouse", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "창고", "In_WareHouse", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 200, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 200, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 150, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목형태", "ITEM_Type", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "수불량", "InOut_Qty", true, 100, DataGridViewContentAlignment.MiddleRight);

            List<CommonCodeVO> common = new List<CommonCodeVO>();
            CommonCodeService comservice = new CommonCodeService();
            common = comservice.GetAllCommonCode();

            List<CommonCodeVO> INOUT = (from item in common
                                        where item.Common_Type == "IN_OUT"
                                        select item).ToList();
            List<CommonCodeVO> Category = (from item in common
                                           where item.Common_Type == "Product_material"
                                           select item).ToList();

            CommonUtil.ComboBinding(cboInOut, INOUT, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboCategory, Category, "Common_Key", "Common_Value", "전체");


            LBJ_Service service = new LBJ_Service();
            dataGridView1.DataSource = service.StockState();
            DataLoad();
        }
        public void DataLoad()
        {
            LBJ_Service service = new LBJ_Service();
            List<StockStateVO> Stock = service.StockState();
            dataGridView1.DataSource = stockVO = Stock;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<StockStateVO> StockState = (from item in stockVO
                                             where item.InOut_Date > dateTimePicker1.Value &&
                                                   item.InOut_Date <= dateTimePicker2.Value &&
                                                   item.InOut_Gubun == cboInOut.Text 
                                             select item).ToList();
            dataGridView1.DataSource = StockState;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string IO = cboInOut.Text.Trim();

            string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string strSql = @"select InOut_No, InOut_Gubun, A.ITEM_Code, ITEM_Name, ITEM_Size, ITEM_Type 
                                  from InOutList A inner join ITEM B on a.ITEM_Code = b.ITEM_Code
                                  WHERE InOut_Gubun = '" + IO + "'  ORDER BY InOut_No";
                SqlDataAdapter da = new SqlDataAdapter(strSql, conn);

                da.Fill(ds, "InOutList");
                conn.Close();
            }

            XtraReport2 rpt = new XtraReport2();
            rpt.DataSource = ds.Tables["InOutList"];

            Form1 frm = new Form1();
            frm.documentViewer1.DocumentSource = rpt;
            frm.ShowDialog();
        }
    }
}
