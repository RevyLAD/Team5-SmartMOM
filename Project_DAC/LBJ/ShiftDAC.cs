using Project_VO.LBJ;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAC.LBJ
{
    public class ShiftDAC:ConnectionAccess
    {
        public List<ShiftVO> Shift()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "AllShift";
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
