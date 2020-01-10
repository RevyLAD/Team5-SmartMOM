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
    public class EnterpriseDAC : ConnectionAccess
    {
        public List<EnterpriseVO> GetAllEnterprise()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetAllEnterprise";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<EnterpriseVO> list = Helper.DataReaderMapToList<EnterpriseVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}
