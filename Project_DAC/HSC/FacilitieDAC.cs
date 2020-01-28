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
    public class FacilitieDAC: ConnectionAccess
    {
        public List<FacilitieVO> GetAllFacilities()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select FACG_No, FACG_Code, FACG_Name, FACG_UseOrNot, FACG_Modifier, FACG_ModifyDate, FACG_Information from FacilityGroup";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<FacilitieVO> list = Helper.DataReaderMapToList<FacilitieVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<FacilitieDetailVO> GetAllFacilitiesDetail()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select FAC_No, FACG_Code, FAC_Code, FAC_Name, FAC_OutWareHouse, FAC_InWareHouse, FAC_BadWareHouse, FAC_UseOrNot, FAC_Modifier, FAC_ModifiyDate, FAC_Remark, FAC_Others from Facility";



                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<FacilitieDetailVO> list = Helper.DataReaderMapToList<FacilitieDetailVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}
