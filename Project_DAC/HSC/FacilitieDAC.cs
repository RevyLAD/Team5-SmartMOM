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

        public void InsertFacilities(FacilitieVO vo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "Insert into FacilityGroup(FACG_NO, [FACG_Code], [FACG_Name], [FACG_UseOrNot], [FACG_Modifier], [FACG_ModifyDate], " +
                                                                            "[FACG_Information]) values(@FACG_NO, @FACG_Code, @FACG_Name, @FACG_UseOrNot, " +
                                                                            "@FACG_Modifier, @FACG_ModifyDate, @FACG_Information)";

                cmd.Parameters.AddWithValue("@FACG_No", vo.FACG_No);
                cmd.Parameters.AddWithValue("@FACG_Code", vo.FACG_Code);
                cmd.Parameters.AddWithValue("@FACG_Name", vo.FACG_Name);
                cmd.Parameters.AddWithValue("@FACG_UseOrNot", vo.FACG_UseOrNot);
                cmd.Parameters.AddWithValue("@FACG_Modifier", vo.FACG_Modifier);
                cmd.Parameters.AddWithValue("@FACG_ModifyDate", vo.FACG_ModifyDate);
                cmd.Parameters.AddWithValue("@FACG_Information", vo.FACG_Information);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<FacilitieDetailVO> list = Helper.DataReaderMapToList<FacilitieDetailVO>(reader);
                cmd.Connection.Close();
            }
        }
    }
}
