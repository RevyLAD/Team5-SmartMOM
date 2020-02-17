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

        //public List<FacVOpp> GetFACName2()
        //{
        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        cmd.Connection = new SqlConnection(this.ConnectionString);
        //        cmd.CommandText = "SELECT FAC_Name, FAC_Code from Facility";

        //        cmd.Connection.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        List<FacVOpp> list = Helper.DataReaderMapToList<FacVOpp>(reader);
        //        cmd.Connection.Close();

        //        return list;
        //    }
        //}

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

        public string[] GetGaDongInfo(string name)
        {
            {
                string[] gname = new string[2];
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(this.ConnectionString);
                    cmd.CommandText = "SELECT FACG_Code from Facility where FAC_Name=@FAC_Name";
                    cmd.Parameters.AddWithValue("@FAC_Name", name);
                    
                    cmd.Connection.Open();
                    gname[0] = Convert.ToString(cmd.ExecuteScalar());

                    cmd.CommandText = "SELECT FACG_Name from FacilityGroup where FACG_Code = (SELECT FACG_Code from Facility where FAC_Name=@FAC_Name)";
                    gname[1] = Convert.ToString(cmd.ExecuteScalar());

                    cmd.Connection.Close();
                }
                return gname;
            }
        }

        public string[] GetPlanTime(string name)
        {
            {
                string[] time = new string[2];
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(this.ConnectionString);
                    cmd.CommandText = "SELECT Shift_StartTime from Shift where FAC_Code = (Select FAC_Code from Facility where FAC_Name=@FAC_Name)";
                    cmd.Parameters.AddWithValue("@FAC_Name", name);

                    cmd.Connection.Open();
                    time[0] = Convert.ToString(cmd.ExecuteScalar());

                    cmd.CommandText = "SELECT Shift_EndTime from Shift where FAC_Code = (Select FAC_Code from Facility where FAC_Name=@FAC_Name)";
                    time[1] = Convert.ToString(cmd.ExecuteScalar());

                    cmd.Connection.Close();
                }
                return time;
            }
        }

        public string GetItemName(string code)
        {
            string name = string.Empty;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT ITEM_Name from ITEM where ITEM_Code = @ITEM_Code";
                cmd.Parameters.AddWithValue("@ITEM_Code", code);

                cmd.Connection.Open();
                name = Convert.ToString(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
            return name;
        }

        public int GetPortNum(string id)
        {
            int portnum = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT FAC_Name from WorkOrder where WO_ID = @WO_ID";
                cmd.Parameters.AddWithValue("@WO_ID", id);

                cmd.Connection.Open();
                string temp = Convert.ToString(cmd.ExecuteScalar()).Trim();
                switch (temp)
                {
                    case "Leg_조립반":
                        portnum = 1000;
                        break;
                    case "SEAT 가공반":
                        portnum = 2000;
                        break;
                    case "LEGS 가공반":
                        portnum = 3000;
                        break;
                    case "최종조립반":
                        portnum = 4000;
                        break;
                    case "외주작업장":
                        portnum = 5000;
                        break;
                }
                
                cmd.Connection.Close();
            }
            return portnum;
        }

        public void SavePopData(List<string> list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "insert into values() where WO_ID = @WO_ID";

                cmd.Parameters.AddWithValue("@WO_ID", list[0]);
                cmd.Parameters.AddWithValue("@WO_ID", list[1]);
                cmd.Parameters.AddWithValue("@WO_ID", list[2]);
                cmd.Parameters.AddWithValue("@WO_ID", list[3]);
                cmd.Parameters.AddWithValue("@WO_ID", list[4]);
                cmd.Parameters.AddWithValue("@WO_ID", list[5]);
                cmd.Parameters.AddWithValue("@WO_ID", list[6]);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        public void WritePoPLog(List<string> list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "insert into values() where WO_ID = @WO_ID";

                cmd.Parameters.AddWithValue("@WO_ID", list[0]);
                cmd.Parameters.AddWithValue("@WO_ID", list[1]);
                cmd.Parameters.AddWithValue("@WO_ID", list[2]);
                cmd.Parameters.AddWithValue("@WO_ID", list[3]);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
    }
}