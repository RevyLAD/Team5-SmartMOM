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
    }
}
