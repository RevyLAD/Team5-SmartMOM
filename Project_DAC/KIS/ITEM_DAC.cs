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
    public class ITEM_DAC : ConnectionAccess
    {
        public List<ITEM_VO> ShowAllITEM()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select * from ITEM ";


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ITEM_VO> list = Helper.DataReaderMapToList<ITEM_VO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public bool InsertItem(ITEM_VO list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "Insert into Item(ITEM_Code, ITEM_Name, ITEM_Size, ITEM_Unit, ITEM_Type,ITEM_ImportIns, ITEM_ProcessIns, ITEM_ShipmentIns, ITEM_OrderComp,ITEM_InWarehouse, ITEM_OutWarehouse, ITEM_MinOrderQuantity, ITEM_SafeQuantity,ITEM_Grade, ITEM_Manager, ITEM_Modifier, ITEM_ModifiyDate, ITEM_UserOrNot,ITEM_OrderMethod, ITEM_Others)" +
                    " values(@ITEM_Code ,@ITEM_Name,@ITEM_Size,@ITEM_Unit,@ITEM_Type,@ITEM_ImportIns ,@ITEM_ProcessIns ,@ITEM_ShipmentIns,@ITEM_OrderComp,@ITEM_InWarehouse ,@ITEM_OutWarehouse ,@ITEM_MinOrderQuantity ,@ITEM_SafeQuantity ,@ITEM_Grade ,@ITEM_Manager ,@ITEM_Modifier ,@ITEM_ModifiyDate ,@ITEM_UserOrNot ,@ITEM_OrderMethod,@ITEM_Others );";

                cmd.Parameters.AddWithValue("@ITEM_Code ", list.ITEM_Code);
                cmd.Parameters.AddWithValue("@ITEM_Name ", list.ITEM_Name);
                cmd.Parameters.AddWithValue("@ITEM_Size ", list.ITEM_Size);
                cmd.Parameters.AddWithValue("@ITEM_Unit ", list.ITEM_Unit);
                cmd.Parameters.AddWithValue("@ITEM_Type ", list.ITEM_Type);
                cmd.Parameters.AddWithValue("@ITEM_ImportIns ", list.ITEM_ImportIns);
                cmd.Parameters.AddWithValue("@ITEM_ProcessIns ", list.ITEM_ProcessIns);
                cmd.Parameters.AddWithValue("@ITEM_ShipmentIns ", list.ITEM_ShipmentIns);
                cmd.Parameters.AddWithValue("@ITEM_OrderComp ", list.ITEM_OrderComp);
                cmd.Parameters.AddWithValue("@ITEM_InWarehouse ", list.ITEM_InWarehouse);
                cmd.Parameters.AddWithValue("@ITEM_OutWarehouse ", list.ITEM_OutWarehouse);
                cmd.Parameters.AddWithValue("@ITEM_MinOrderQuantity ", list.ITEM_MinOrderQuantity);
                cmd.Parameters.AddWithValue("@ITEM_SafeQuantity ", list.ITEM_SafeQuantity);
                cmd.Parameters.AddWithValue("@ITEM_Manager ", list.ITEM_Manager);
                cmd.Parameters.AddWithValue("@ITEM_Modifier ", list.ITEM_Modifier);
                cmd.Parameters.AddWithValue("@ITEM_Grade ", list.ITEM_Grade);
                cmd.Parameters.AddWithValue("@ITEM_ModifiyDate ", list.ITEM_ModifiyDate);
                cmd.Parameters.AddWithValue("@ITEM_UserOrNot ", list.ITEM_UserOrNot);
                cmd.Parameters.AddWithValue("@ITEM_OrderMethod ", list.ITEM_OrderMethod);
                cmd.Parameters.AddWithValue("@ITEM_Others ", list.ITEM_Others);


                cmd.Connection.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return rowsAffected > 0;
            }
        }

       
    }
}
