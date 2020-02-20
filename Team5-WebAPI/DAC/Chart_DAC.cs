using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Team5_WebAPI.Models;

namespace Team5_WebAPI.DAC
{
    public class Chart_DAC
    {
        string StrConn = string.Empty;
        public Chart_DAC()
        {
            StrConn = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        }


        public List<Chart_VO> GetChartData()
        {
            List<Chart_VO> list = new List<Chart_VO>();
            string sql = @"select COM_Code, sum(SALES_OrderQty) as Qty , coalesce(sum(Sales_shipQty),0) as Sales_shipQty, Month(SALES_OrderDate) as MM from SalesMaster  group by  Month(SALES_OrderDate) ,COM_Code";

            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    list = Helper.DataReaderMapToList<Chart_VO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }
    }
}
