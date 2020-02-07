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
    public class Matarial_DAC : ConnectionAccess
    {
        public List<Material_VO_VIew> ShowMaterial()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = " select A.Material_No,A.COM_Code,B.COM_Name,A.ITEM_Code,C.ITEM_Name,C.ITEM_Size ,C.ITEM_Unit,A.Material_Price_Now,A.Material_Price_Previous,A.Material_StartDate,A.Material_EndDate,A.Material_UseOrNot,A.Material_Editer,A.Material_EditDate,A.Material_Others from Material_price A inner join Company B on A.COM_Code = B.COM_Code inner join ITEM C on A.ITEM_Code = C.ITEM_Code Where Material_StartDate between CONVERT(VARCHAR, DATEADD(MM, DATEDIFF(MM,0,  GETDATE()) ,0), 121) and CONVERT(VARCHAR, DATEADD(SS, -1, DATEADD(MM, DATEDIFF(MM, 0, GETDATE()) + 1, 0)), 121) order by COM_Code , Material_StartDate ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Material_VO_VIew> list = Helper.DataReaderMapToList<Material_VO_VIew>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public bool InsertIMaterial(Material_VO list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "MaterialInsertUpdate";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@COM_Code ", list.ITEM_Code);
                cmd.Parameters.AddWithValue("@ITEM_Code ", list.ITEM_Code);
                cmd.Parameters.AddWithValue("@Material_Price_Now ", list.Material_Price_Now);
                cmd.Parameters.AddWithValue("@Material_Price_Previous ", list.Material_Price_Previous);
                cmd.Parameters.AddWithValue("@Material_StartDate ", list.Material_StartDate);
                cmd.Parameters.AddWithValue("@Material_EndDate ", list.Material_EndDate);
                cmd.Parameters.AddWithValue("@Material_UseOrNot ", list.Material_UseOrNot);
                cmd.Parameters.AddWithValue("@Material_Editer ", list.Material_Editer);
                cmd.Parameters.AddWithValue("@Material_EditDate ", list.Material_EditDate);
                cmd.Parameters.AddWithValue("@Material_Others ", list.Material_Others);
        


                cmd.Connection.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return rowsAffected > 0;
            }
        }

        public List<Material_VO_VIew> SearchMaterial(string date, string name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SearchMaterial";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date ", date);
                cmd.Parameters.AddWithValue("@ITEM_Code ", name);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Material_VO_VIew> list = Helper.DataReaderMapToList<Material_VO_VIew>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public bool DeleteMaterial(string list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "Delete From Material_Price where Material_No in ( " + list + ")";

                //cmd.Parameters.AddWithValue("@List ",Convert.ToInt32(list));
                cmd.Connection.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rowsAffected > 0;
            }
        }

    }
}
