using Project_VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAC
{
    public class Sales_DAC : ConnectionAccess
    {
        public List<Sales_VO_VIew> ShowSales()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText =$"select A.Sales_No,A.COM_Code,B.COM_Name,A.ITEM_Code,C.ITEM_Name,C.ITEM_Size ,C.ITEM_Unit,A.Sales_Price_Now,A.Sales_Price_Previous,A.Sales_StartDate,A.Sales_EndDate,A.Sales_UseOrNot,A.Sales_Editer,A.Sales_EditDate,A.Sales_Others from Sales_Price A inner join Company B on A.COM_Code = B.COM_Code inner join ITEM C on A.ITEM_Code = C.ITEM_Code where Sales_StartDate between CONVERT(VARCHAR, DATEADD(MM, DATEDIFF(MM,0,  GETDATE()) ,0), 121) and CONVERT(VARCHAR, DATEADD(SS, -1, DATEADD(MM, DATEDIFF(MM, 0, GETDATE()) + 1, 0)), 121) order by COM_Code , Sales_startDate";
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Sales_VO_VIew> list = Helper.DataReaderMapToList<Sales_VO_VIew>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public SqlParameter InsertISales(Sales_VO list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SalesInsertUpdate";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@COM_Code ", list.COM_Code);
                cmd.Parameters.AddWithValue("@ITEM_Code ", list.ITEM_Code);
                cmd.Parameters.AddWithValue("@Sales_Price_Now ", list.Sales_Price_Now);
                cmd.Parameters.AddWithValue("@Sales_Price_Previous ", list.Sales_Price_Previous);
                cmd.Parameters.AddWithValue("@Sales_StartDate ", list.Sales_StartDate);
                cmd.Parameters.AddWithValue("@Sales_EndDate ", list.Sales_EndDate);
                cmd.Parameters.AddWithValue("@Sales_UseOrNot ", list.Sales_UseOrNot);
                cmd.Parameters.AddWithValue("@Sales_Editer ", list.Sales_Editer);
                cmd.Parameters.AddWithValue("@Sales_EditDate ", list.Sales_EditDate);
                cmd.Parameters.AddWithValue("@Sales_Others ", list.Sales_Others);
                SqlParameter reparm = new SqlParameter();
                reparm.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(reparm);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return reparm;
            }
        }
        public List<Sales_VO_VIew> SearchSales(string date , string name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SearchSales";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date ", date);
                cmd.Parameters.AddWithValue("@ITEM_Code ", name);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Sales_VO_VIew> list = Helper.DataReaderMapToList<Sales_VO_VIew>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public bool DeleteSales(string list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "Delete From Sales_Price where Sales_No in ( " + list + ")";

                //cmd.Parameters.AddWithValue("@List ",Convert.ToInt32(list));
                cmd.Connection.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rowsAffected > 0;
            }
        }
    }
}
