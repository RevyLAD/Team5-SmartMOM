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
        DateTimePicker dtp;
        List<StockStateVO> stockVO;
        public Stock_RF_State()
        {
            InitializeComponent();
        }

        private void Stock_RF_State_Load(object sender, EventArgs e)
        {
            DateTimePicker dtp = new DateTimePicker();
            dateTimePicker1.Value = dtp.Value;
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(7);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "InOut_No", true, 50, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "입출고일", "InOut_Date", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "구분", "InOut_Gubun", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "카테고리", "InOut_Category", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "From창고", "From_WareHouse", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "창고", "In_WareHouse", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 200, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 200, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 150, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목형태", "ITEM_Type", true, 100, DataGridViewContentAlignment.MiddleCenter);
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


            LBJ_Service service = new LBJ_Service();
            dataGridView1.DataSource = service.StockState();
            DataLoad();
        }
        public void DataLoad()
        {
            LBJ_Service service = new LBJ_Service();
            List<StockStateVO> Stock = service.StockState();
            dataGridView1.DataSource = stockVO = StockState = Stock;
        }
        List<StockStateVO> StockState;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            StockState = (from item in stockVO
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
            List<StockStateVO> templist = new List<StockStateVO>();

            StockStateVO vo = new StockStateVO();

            foreach (StockStateVO tempvo in StockState)
            {
                vo.InOut_No = tempvo.InOut_No;
                vo.InOut_Gubun = tempvo.InOut_Gubun;
                vo.ITEM_Code = tempvo.ITEM_Code;
                vo.ITEM_Name = tempvo.ITEM_Name;
                vo.ITEM_Size = tempvo.ITEM_Size;
                vo.ITEM_Type = tempvo.ITEM_Type;

                templist.Add(vo);
            }

            //DataSet ds = new DataSet();
            //using (SqlConnection conn = new SqlConnection(strConn))
            //{
            //    conn.Open();
            //    string strSql = @"select InOut_No, InOut_Gubun, A.ITEM_Code, ITEM_Name, ITEM_Size, ITEM_Type 
            //                      from InOutList A inner join ITEM B on a.ITEM_Code = b.ITEM_Code
            //                      WHERE InOut_Gubun = '" + IO + "'  ORDER BY InOut_No";


            //    SqlDataAdapter da = new SqlDataAdapter(strSql, conn);

            //    da.Fill(ds, "InOutList");
            //    conn.Close();
            //}

            XtraReport2 rpt = new XtraReport2();
            //rpt.DataSource = ds.Tables["InOutList"];

            DataTable dt = new DataTable();
            dt = ConvertToDataTable<StockStateVO>(templist);
            rpt.DataSource = dt;

            Form1 frm = new Form1();
            frm.documentViewer1.DocumentSource = rpt;
            frm.ShowDialog();
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                    values[i] = props[i].GetValue(item);

                table.Rows.Add(values);
            }
            return table;
        }
    }
}
