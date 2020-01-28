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
    public class BOM_DAC : ConnectionAccess
    {
        public List<BOM_VO> ShowAllBOM()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select * from BOM ";


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<BOM_VO> list = Helper.DataReaderMapToList<BOM_VO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public bool InsertBOM(BOM_VO list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "BOMInsertItem";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BOM_Code ", list.BOM_Code);
                cmd.Parameters.AddWithValue("@ITEM_Code", list.ITEM_Code);
                cmd.Parameters.AddWithValue("@BOM_Require", list.BOM_Require);
                cmd.Parameters.AddWithValue("@BOM_StartDate", list.BOM_StartDate);
                cmd.Parameters.AddWithValue("@BOM_EndDate", list.BOM_EndDate);
                cmd.Parameters.AddWithValue("@BOM_UseOrNot", list.BOM_UseOrNot);
                cmd.Parameters.AddWithValue("@BOM_Modifier", list.BOM_Modifier);
                cmd.Parameters.AddWithValue("@BOM_ModifiyDate", list.BOM_ModifiyDate);
                cmd.Parameters.AddWithValue("@BOM_AutoDeduction", list.BOM_AutoDeduction);
                cmd.Parameters.AddWithValue("@BOM_RequirePlan", list.BOM_RequirePlan);
                cmd.Parameters.AddWithValue("@BOM_Others", list.BOM_Others);
                cmd.Connection.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return rowsAffected > 0;
            }
        }
        public bool DeleteBOM(string list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "Delete From BOM where BOM_No in ( " + list  + ")";
               
                //cmd.Parameters.AddWithValue("@List ",Convert.ToInt32(list));
                cmd.Connection.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                
                return rowsAffected > 0;
            }
        }


        public List<BOM_Serch_VO> BOM_SearchData(string name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "BOMSearchData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BOM_Name ", name);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<BOM_Serch_VO> list = Helper.DataReaderMapToList<BOM_Serch_VO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

    }
}
