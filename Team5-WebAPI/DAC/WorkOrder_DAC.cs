using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Team5_WebAPI.Models;

namespace Team5_WebAPI.DAC
{
    public class WorkOrder_DAC
    {
        string StrConn = string.Empty;
        public WorkOrder_DAC()
        {
            StrConn = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        }

        public List<WorkOrder_VO> ProductCharts()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(StrConn);
                cmd.CommandText = $"select FAC_Name, count(case when Qty = 'B' then 1 end) as B_Qty,count(case when Qty = 'G' then 1 end) as Q_qty ,round(CAST(CAST(count(case when Qty = 'G' then 1 end) AS FLOAT) AS FLOAT) / CAST((count(case when Qty = 'B' then 1 end) + count(case when Qty = 'G' then 1 end)) AS DECIMAL) * 100, -1) as G_QtyMIN ,round(CAST(CAST(count(case when Qty = 'B' then 1 end) AS FLOAT) AS FLOAT) / CAST((count(case when Qty = 'B' then 1 end) + count(case when Qty = 'G' then 1 end)) AS DECIMAL) * 100, -1) as B_QtyMIN from ProductionLog group by FAC_Name";
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrder_VO> list = Helper.DataReaderMapToList<WorkOrder_VO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}