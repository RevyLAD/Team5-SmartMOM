using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team5_SmartMOM;
using System.Data.SqlClient;
using System.Data;
using Project_VO;
namespace Project_DAC
{
    public class ShiftDAC : ConnectionAccess
    {
        public List<ShiftVO> Shift()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "Shift";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ShiftVO> list = Helper.DataReaderMapToList<ShiftVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}
