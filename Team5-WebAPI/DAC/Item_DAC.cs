using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Team5_WebAPI.Models;

namespace Team5_WebAPI.DAC
{
    public class Item_DAC
    {
        string StrConn = string.Empty;
        public Item_DAC()
        {
            StrConn = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        }
        public List<Item_VO> BOM_SearchData()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(StrConn);
                cmd.CommandText =$"WITH BOM_Table(BOM_Code, ITEM_Code, BOM_Require, BOM_StartDate, BOM_EndDate, BOM_UseOrNot, BOM_Modifier, BOM_ModifiyDate, BOM_AutoDeduction, BOM_RequirePlan, BOM_Others , Levels) as ( select BOM_Code, ITEM_Code, BOM_Require, BOM_StartDate, BOM_EndDate, BOM_UseOrNot, BOM_Modifier, BOM_ModifiyDate, BOM_AutoDeduction, BOM_RequirePlan, BOM_Others,0 from BOM where ITEM_Code = 'CHAIR_01' UNION ALL select AA.BOM_Code, AA.ITEM_Code, AA.BOM_Require,AA.BOM_StartDate, AA.BOM_EndDate, AA.BOM_UseOrNot, AA.BOM_Modifier, AA.BOM_ModifiyDate, AA.BOM_AutoDeduction, AA.BOM_RequirePlan, AA.BOM_Others ,BB.Levels + 1 from BOM as AA inner join BOM_Table as BB on AA.BOM_Code = BB.ITEM_Code ) select BOM_Code, A.ITEM_Code ,B.ITEM_Name,B.ITEM_Type ,BOM_Require, BOM_StartDate, BOM_EndDate, BOM_UseOrNot, BOM_Modifier, BOM_ModifiyDate, BOM_AutoDeduction, BOM_RequirePlan, BOM_Others ,Levels from BOM_Table A inner join ITEM B on B.ITEM_Code = A.ITEM_Code order by Levels";
              
               
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Item_VO> list = Helper.DataReaderMapToList<Item_VO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public List<WorkOrder_VO2> Count_Item()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(StrConn);
                cmd.CommandText = $"select count(ITEM_Code) as Allcount from ITEM";


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrder_VO2> list = Helper.DataReaderMapToList<WorkOrder_VO2>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}