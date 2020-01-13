using Project_VO;

using System;
using System.Collections.Generic;
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
    }
}
