using Project_VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Project_DAC
{
    public class FactoryDAC:ConnectionAccess
    {
        public List<FactoryVO> GetAllFactory()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetAllFactory";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<FactoryVO> list = Helper.DataReaderMapToList<FactoryVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}
