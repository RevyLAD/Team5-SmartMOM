using Project_DAC;
using Project_VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5_Pop
{
    public class PopDAC : ConnectionAccess
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

        public List<FacGroupVO> GetFACGName()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT FACG_Name, FACG_Code from FacilityGroup";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<FacGroupVO> list = Helper.DataReaderMapToList<FacGroupVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<FacVOp> GetFACName()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT FAC_Name, FAC_Code, FACG_Code from Facility";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<FacVOp> list = Helper.DataReaderMapToList<FacVOp>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public void UpdateFacState(string name, string id)
        {
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(this.ConnectionString);
                    cmd.CommandText = "update Facility Set FAC_Others='가동' where FAC_Name=@FAC_Name";
                    cmd.Parameters.AddWithValue("@FAC_Name", name);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update [WorkOrder] Set [WO_State]='작업시작' where [WO_ID]=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
            }
        }
        public string GetFacState(string name)
        {
            {
                string state;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(this.ConnectionString);
                    cmd.CommandText = "SELECT FAC_Others from Facility where FAC_Name=@FAC_Name";
                    cmd.Parameters.AddWithValue("@FAC_Name", name);
                    cmd.Connection.Open();
                    state = Convert.ToString(cmd.ExecuteScalar());
                    cmd.Connection.Close();
                }
                return state;
            }
        }
    }
}
