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
                cmd.CommandText = "SELECT [WO_ID], [ITEM_Code], [FAC_Name], [WO_StartDate], [WO_EndDate], [planQty], [directQty], [WO_State], [Plan_ID], [WO_Priority], [WO_Time] ,[WO_GoodQty] ,[WO_BadQty],[WO_WorkEndTime] ,[restQty] from [WorkOrder] where WO_State = '작업지시' or WO_State = '작업시작' or WO_State = '작업중지'";

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
                cmd.CommandText = "SELECT [WO_ID], [ITEM_Code], [FAC_Name], [WO_StartDate], [WO_EndDate], [planQty], [directQty], [WO_State], [Plan_ID], [WO_Priority], [WO_Time], WO_GoodQty, WO_BadQty, WO_WorkEndTime, [restQty] from [WorkOrder] where WO_ID = @WO_ID ";
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
                    //cmd.CommandText = "update Facility Set FAC_Others='가동', WO_ID=@id where FAC_Name=@FAC_Name";
                    cmd.CommandText = "update Facility Set WO_ID=@id where FAC_Name=@FAC_Name";
                    cmd.Parameters.AddWithValue("@FAC_Name", name);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "update Facility Set FAC_Others = '가동' where WO_ID = @id";
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
            string ipaddress = string.Empty;
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
                        //ipaddress = "127.0.0.1";
                        break;
                    case "SEAT 가공반":
                        //ipaddress = "127.0.0.2";
                        portnum = 2000;
                        break;
                    case "LEGS 가공반":
                        //ipaddress = "127.0.0.3";
                        portnum = 3000;
                        break;
                    case "최종조립반":
                        //ipaddress = "127.0.0.4";
                        portnum = 4000;
                        break;
                    case "외주작업장":
                        //ipaddress = "127.0.0.5";
                        portnum = 5000;
                        break;
                }
                cmd.Connection.Close();
            }
            return portnum;
        }

        public void SavePopData(PoPEndVO vo)
        {
            using (SqlConnection conn = new SqlConnection(this.ConnectionString))
            {
                conn.Open();

                SqlTransaction tran = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.Transaction = tran;

                cmd.Parameters.AddWithValue("@WO_ID", vo.WO_ID);
                cmd.Parameters.AddWithValue("@WO_State", vo.WO_State);
                cmd.Parameters.AddWithValue("@GoodQty", vo.GoodQty);
                cmd.Parameters.AddWithValue("@BadQty", vo.BadQty);
                cmd.Parameters.AddWithValue("@restQty", vo.restQty);
                cmd.Parameters.AddWithValue("@WO_WorkEndTime", vo.WO_WorkEndTime);
                cmd.Parameters.AddWithValue("@TotalQty", (vo.GoodQty + vo.BadQty));
                cmd.Parameters.AddWithValue("@ITEM_Code", vo.ITEM_Code);
                cmd.Parameters.AddWithValue("@FAC_Name", vo.FAC_Name);

                cmd.CommandText = "update Facility Set FAC_Others='비가동', WO_ID=null where FAC_Name=@FAC_Name";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "update WorkOrder set WO_State = @WO_State, WO_GoodQty = @GoodQty, WO_BadQty = @BadQty, restQty = @restQty, WO_WorkEndTime = @WO_WorkEndTime where WO_ID = @WO_ID";
                cmd.ExecuteNonQuery();

                if (!(vo.ITEM_Code == "CHAIR_01"))
                {
                    cmd.CommandText = "update FactoryDetail set FACD_Qty = FACD_Qty+@GoodQty where ITEM_Code = @ITEM_Code";
                    cmd.ExecuteNonQuery();
                }

                cmd.CommandText = "DECLARE " +
                    "@REQUIRE int, " +
                    "@ITEM VARCHAR(50)  " +
                    "DECLARE CUR CURSOR FOR " +
                    "select BOM_Require_2, ITEM_Code from BOM " +
                    "where BOM_Code = @ITEM_Code and BOM_FinalBOM = 'CHAIR_01'" +
                    "OPEN CUR " +
                    "FETCH NEXT FROM CUR INTO @REQUIRE, @ITEM " +
                    "WHILE @@FETCH_STATUS = 0 " +
                    "BEGIN " +
                    "update FactoryDetail " +
                    "set FACD_Qty = FACD_Qty - (@REQUIRE * @TotalQty)" +
                    "where ITEM_Code = @ITEM and FACT_Code = 'H_01'" +
                    "FETCH NEXT FROM CUR INTO @REQUIRE, @ITEM " +
                    "END " +
                    "CLOSE CUR " +
                    "DEALLOCATE CUR";


                cmd.ExecuteNonQuery();

                cmd.Transaction.Commit();
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

        public void UpdateRequire(string item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "  update FactoryDetail set FACD_Qty = FACD_Qty - (select BOM_Require from BOM where BOM_Code = @BOM_Code) " +
                    "where ITEM_Code = (select ITEM_Code from BOM where BOM_Code = @BOM_Code) and FACT_Code = 'H_01'";
               
                cmd.Parameters.AddWithValue("@BOM_Code", item);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
    }
}