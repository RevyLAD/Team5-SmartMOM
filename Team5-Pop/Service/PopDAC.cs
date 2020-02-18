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
        public List<PopVO> GetPoPVOByWoId(string woId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT [WO_ID], [ITEM_Code], [FAC_Name], [WO_StartDate], [WO_EndDate], [planQty], [directQty], [WO_State], [Plan_ID], [WO_Priority], [WO_Time] from [WorkOrder] where WO_ID = @WO_ID ";
                cmd.Parameters.AddWithValue("@WO_ID", woId);
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

        public string GetFACNameByWoId(string woId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT distinct FAC_Name from WorkOrder where WO_ID = @WO_ID";
                cmd.Parameters.AddWithValue("@WO_ID", woId);

                cmd.Connection.Open();
                string facName = cmd.ExecuteScalar().ToString();
                cmd.Connection.Close();

                return facName;
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
                    cmd.CommandText = "update Facility Set FAC_Others='가동', WO_ID=@id where FAC_Name=@FAC_Name";
                    cmd.Parameters.AddWithValue("@FAC_Name", name);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update [WorkOrder] Set [WO_State]='작업시작' where [WO_ID]=@id";
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

        public void WritePoPLog(PoPLogVO logvo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "insert into ProductionLog(WO_ID, FAC_Name, ITEM_Code, ProductTime, Qty) values(@WO_ID, @FAC_Name, @ITEM_Code, @ProductTime, @Qty)";

                cmd.Parameters.AddWithValue("@WO_ID", logvo.WO_ID);
                cmd.Parameters.AddWithValue("@FAC_Name", logvo.FAC_Name);
                cmd.Parameters.AddWithValue("@ITEM_Code", logvo.ITEM_Code);
                cmd.Parameters.AddWithValue("@ProductTime", logvo.ProductTime);
                cmd.Parameters.AddWithValue("@Qty", logvo.Qty);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        public List<ControlVO> GetInfoForControl(string id, string name)
        {
            List<ControlVO> volist;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                
                cmd.CommandText = "select WO_ID, FAC_Name, ITEM_Code, " +
                    "(select directQty from WorkOrder where WO_ID = @WO_ID) as 'directQty'," +
                    "(select Count(Qty) from ProductionLog where WO_ID = @WO_ID and Qty='G' and FAC_Name = @FAC_Name) as 'GoodQty', " +
                    "(select Count(Qty) from ProductionLog where WO_ID = @WO_ID and Qty='B' and FAC_Name = @FAC_Name) as 'BadQty' " +
                    "from ProductionLog where WO_ID = @WO_ID and FAC_Name = @FAC_Name group by FAC_Name, ITEM_Code, WO_ID";

                cmd.Parameters.AddWithValue("@WO_ID", id);
                cmd.Parameters.AddWithValue("@FAC_Name", name);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                volist = Helper.DataReaderMapToList<ControlVO>(reader);
                cmd.Connection.Close();
            }

            return volist;
        }

        public string GetFACSignal(string FacName)
        {
            string signal;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select FAC_Others from Facility where FAC_Name = @FAC_Name";
                cmd.Parameters.AddWithValue("@FAC_Name", FacName);

                cmd.Connection.Open();
                signal = Convert.ToString(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
            return signal;
        }

        public List<NewControlVO> GetNewControl()
        {
            List<NewControlVO> templist = new List<NewControlVO>();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select WO_ID, FAC_Name from Facility ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                templist = Helper.DataReaderMapToList<NewControlVO>(reader);
                cmd.Connection.Close();
            }
            return templist;
        }

        public string GetWO_ID(string FacName)
        {
            string wo_id;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select WO_ID from Facility where FAC_Name = @FAC_Name";
                cmd.Parameters.AddWithValue("@FAC_Name", FacName);

                cmd.Connection.Open();
                wo_id = Convert.ToString(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
            return wo_id;
        }

        public void UpdateFacStateEnd(string FacName)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "update Facility Set FAC_Others='비가동', WO_ID=null where FAC_Name=@FAC_Name";
                cmd.Parameters.AddWithValue("@FAC_Name", FacName);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        public void UpdateFacStatePause(string FacName, int choice)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);

                switch (choice)
                {
                    case 1:
                        cmd.CommandText = "update Facility Set FAC_Others='일시정지' where FAC_Name=@FAC_Name";
                        break;
                    case 2:
                        cmd.CommandText = "update Facility Set FAC_Others='가동' where FAC_Name=@FAC_Name";
                        break;
                }
                
                cmd.Parameters.AddWithValue("@FAC_Name", FacName);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
    }
}