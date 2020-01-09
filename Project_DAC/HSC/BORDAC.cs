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
                cmd.CommandText = "GetAllBOR";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<BORVO> list = Helper.DataReaderMapToList<BORVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}
