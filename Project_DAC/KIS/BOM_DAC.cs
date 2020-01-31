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
        /// <summary>
        ///  프로시저 내용 
        ///  
        /// 	WITH BOM_Table(BOM_Code, ITEM_Code, BOM_Require, BOM_StartDate, BOM_EndDate, BOM_UseOrNot, BOM_Modifier, BOM_ModifiyDate, BOM_AutoDeduction, BOM_RequirePlan, BOM_Others , Levels)
        ///as
        ///(
        ///select BOM_Code, ITEM_Code, BOM_Require, BOM_StartDate, BOM_EndDate, BOM_UseOrNot, BOM_Modifier, BOM_ModifiyDate, BOM_AutoDeduction, BOM_RequirePlan, BOM_Others,0
        ///from BOM
        ///where ITEM_Code = @BOM_Name
        ///UNION ALL
        ///select AA.BOM_Code, AA.ITEM_Code, AA.BOM_Require, AA.BOM_StartDate, AA.BOM_EndDate, AA.BOM_UseOrNot, AA.BOM_Modifier, AA.BOM_ModifiyDate, AA.BOM_AutoDeduction, AA.BOM_RequirePlan, AA.BOM_Others , BB.Levels+1
        ///from BOM as AA inner join BOM_Table as BB on AA.BOM_Code = BB.ITEM_Code
        ///)
        ///select BOM_Code, REPLICATE('ㆍ', Levels)+A.ITEM_Code as ITEM_Code ,REPLICATE('ㆍ', Levels)+B.ITEM_Name as ITEM_Name,B.ITEM_Type ,BOM_Require, BOM_StartDate, BOM_EndDate, BOM_UseOrNot, BOM_Modifier, BOM_ModifiyDate, BOM_AutoDeduction, BOM_RequirePlan, BOM_Others ,Levels from BOM_Table A inner join ITEM B on B.ITEM_Code = A.ITEM_Code order by Levels
        /// </summary>


        public List<BOM_Serch_VO> BOM_SearchData(string name , int type)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "BOMSearchData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BOM_Name ", name);
                cmd.Parameters.AddWithValue("@type ", type);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<BOM_Serch_VO> list = Helper.DataReaderMapToList<BOM_Serch_VO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
      
        public List<ITEM_VO> GetAllCommonCode()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select * from ITEM";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ITEM_VO> list = Helper.DataReaderMapToList<ITEM_VO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public List<BOM_VO1> GetAllCommonCode2()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select BOM_No, BOM_Code, A.ITEM_Code, BOM_Require, BOM_StartDate, BOM_EndDate, BOM_UseOrNot, BOM_Modifier, BOM_ModifiyDate, BOM_AutoDeduction, BOM_RequirePlan, BOM_Others,B.ITEM_Type from BOM A inner join ITEM B on A.ITEM_Code = B.ITEM_Code";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<BOM_VO1> list = Helper.DataReaderMapToList<BOM_VO1>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        
    }
}
