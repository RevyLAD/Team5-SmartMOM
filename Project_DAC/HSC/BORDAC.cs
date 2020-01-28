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
    public class BORDAC:ConnectionAccess
    {

        public List<BORVO> GetAllBOR()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select ITEM_Code, FACG_Code, FAC_Code, BOR_TactTime, BOR_Priority, BOR_yeild, BOR_UseOrNot, BOR_Ohters from BOR";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<BORVO> list = Helper.DataReaderMapToList<BORVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public void InsertBOR(BORVO bvo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "insert into BOR(ITEM_Code, FACG_Code, FAC_Code, BOR_TactTime, BOR_Priority, BOR_yeild, BOR_UseOrNot, BOR_Ohters) values(@ITEM_Code, @FACG_Code, @FAC_Code, @BOR_TactTime, @BOR_Priority, @BOR_yeild, @BOR_UseOrNot, @BOR_Ohters)";

                cmd.Connection.Open();

                cmd.Parameters.AddWithValue("@ITEM_Code", bvo.ITEM_Code);
                cmd.Parameters.AddWithValue("@FACG_Code", bvo.FACG_Code);
                cmd.Parameters.AddWithValue("@FAC_Code", bvo.FAC_Code);
                cmd.Parameters.AddWithValue("@BOR_TactTime", bvo.BOR_TactTime);
                cmd.Parameters.AddWithValue("@BOR_Priority", bvo.BOR_Priority);
                cmd.Parameters.AddWithValue("@BOR_yeild", bvo.BOR_yeild);
                cmd.Parameters.AddWithValue("@BOR_UseOrNot", bvo.BOR_UseOrNot);
                cmd.Parameters.AddWithValue("@BOR_Ohters", bvo.BOR_Ohters);

                SqlDataReader reader = cmd.ExecuteReader();
                List<BORVO> list = Helper.DataReaderMapToList<BORVO>(reader);
                cmd.Connection.Close();
            }
        }
    }
}
