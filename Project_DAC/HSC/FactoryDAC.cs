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
                cmd.CommandText = "SELECT ITEM_Code, FACG_Code, FAC_Code, BOR_TactTime, BOR_Priority, BOR_yeild, BOR_UseOrNot, BOR_Ohters from BOR";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<FactoryVO> list = Helper.DataReaderMapToList<FactoryVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}
