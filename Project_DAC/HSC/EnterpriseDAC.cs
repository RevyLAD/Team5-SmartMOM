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
                cmd.CommandText = "SELECT COM_No, COM_Code, COM_Name, COM_Type, COM_Owner, COM_Sector, COM_Manager, COM_Email, " +
                    "COM_Phone, COM_UseOrNot, COM_Modifier, Convert(nvarchar(10),COM_ModifiyDate,23) COM_ModifiyDate, COM_Information from Company";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<EnterpriseVO> list = Helper.DataReaderMapToList<EnterpriseVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}
