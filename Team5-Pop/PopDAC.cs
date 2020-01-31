using Project_DAC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5_Pop
{
    public class PopDAC:ConnectionAccess
    {
        public List<PopVO> PopGetData()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT [WO_ID], [ITEM_Code], [FAC_Name], [WO_StartDate], [WO_EndDate], [planQty], [directQty], [WO_State], [Plan_ID], [WO_Priority], [WO_Time] from [WorkOrder]";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PopVO> list = Helper.DataReaderMapToList<PopVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}
