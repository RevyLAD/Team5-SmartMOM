using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Team5_WebAPI.Models;

namespace Team5_WebAPI.DAC
{
    public class Sales_DAC
    {
        string StrConn = string.Empty;
        public Sales_DAC()
        {
            StrConn = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        }

        public List<Sales_VO> Search_PriceOrder()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(StrConn);
                cmd.CommandText = $"select COM_Code  ,Sales_Price_Now , MONTH(Sales_StartDate) as Sales_StartDate , Sales_Editer , Sales_EditDate from Sales_Price A  where COM_Code='CU' and year(Sales_StartDate)=Year(GETDATE()) group by Sales_StartDate,COM_Code,Sales_Price_Now,Sales_Editer,Sales_EditDate order by Sales_StartDate";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Sales_VO> list = Helper.DataReaderMapToList<Sales_VO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}