using Project_VO.HSM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAC.HSM
{
    public class WorkOrderDAC : ConnectionAccess
    {
        public List<WorkOrderVO> GetWorkOrderByPlan(WorkOrderListVO wo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                string sql;
                if (wo.Plan_ID == "전체")
                {
                    sql = @"select WO_ID,w.Item_code,Item_Name, Fac_Name, CONVERT(nvarchar(10),WO_Startdate,23) WO_Startdate , CONVERT(nvarchar(10),WO_EndDate,23) WO_EndDate,
                                    planQty, directQty, Wo_state, plan_ID, WO_Priority, WO_Time
                                    from WorkOrder w , Item i
                                    where WO_State = @WO_State
                                    and WO_StartDate >= @WO_Startdate
                                    and WO_EndDate <= @WO_EndDate
                                    and w.Item_code = i.ITEM_Code
                                    ORDER BY Plan_ID ";
                }
                else
                {
                    sql = @"select WO_ID,w.Item_code,Item_Name, Fac_Name, CONVERT(nvarchar(10),WO_Startdate,23) WO_Startdate , CONVERT(nvarchar(10),WO_EndDate,23) WO_EndDate,
                                    planQty, directQty, Wo_state, plan_ID, WO_Priority, WO_Time
                                    from WorkOrder w , Item i
                                    where WO_State = @WO_State
                                    and Plan_ID = @Plan_ID
                                    and WO_StartDate >= @WO_Startdate
                                    and WO_EndDate <= @WO_EndDate
                                    and w.Item_code = i.ITEM_Code
                                    ORDER BY Plan_ID ";
                }
               


                cmd.CommandText = sql;

                cmd.Connection.Open();

                cmd.Parameters.AddWithValue("@WO_Startdate", wo.WO_StartDate);
                cmd.Parameters.AddWithValue("@WO_EndDate", wo.WO_EndDate);
                cmd.Parameters.AddWithValue("@WO_State", wo.WO_State);
                cmd.Parameters.AddWithValue("@Plan_ID", wo.Plan_ID);

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }


        public List<WorkOrderVO> GetWorkOrderList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = @"select WO_ID,w.Item_code,Item_Name, Fac_Name, CONVERT(nvarchar(10),WO_Startdate,23) WO_Startdate , CONVERT(nvarchar(10),WO_EndDate,23) WO_EndDate,
                                    planQty, directQty, Wo_state, plan_ID, WO_Priority, WO_Time
                                    from WorkOrder w , Item i
                                    where WO_State = '작업지시'
                                    and w.Item_code = i.ITEM_Code
                                    ORDER BY Plan_ID ";

                cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public List<WorkOrderVO> GetWorkOrderByPlanId(SearchWorkOrderVO wo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                string sql = @"select WO_ID,w.Item_code,Item_Name, Fac_Name, CONVERT(nvarchar(10),WO_Startdate,23) WO_Startdate , CONVERT(nvarchar(10),WO_EndDate,23) WO_EndDate,
                                    planQty, directQty, Wo_state, plan_ID, WO_Priority, WO_Time
                                    from WorkOrder w , Item i
                                    where Plan_Id = @Plan_Id
                                    and WO_StartDate >= @WO_Startdate
                                    and WO_EndDate <= @WO_EndDate
                                    and WO_State = @WO_State
                                    and w.Item_code = i.ITEM_Code
                                     ";

                cmd.CommandText = sql;
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@Plan_Id", wo.Plan_ID);
                cmd.Parameters.AddWithValue("@WO_StartDate", wo.WO_StartDate);
                cmd.Parameters.AddWithValue("@WO_EndDate", wo.WO_EndDate);
                cmd.Parameters.AddWithValue("@WO_State", wo.WO_State);

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }


        public bool InsertWorkOrder(string planId)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = new SqlConnection(this.ConnectionString);
                    cmd.Connection.Open();

                    cmd.CommandText = "InsertWorkOrder";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Plan_ID", planId);

                    cmd.ExecuteNonQuery();

                    cmd.Connection.Close();
                }

                return true;


            }
            catch (Exception err)
            {

                return false;
            }

        }

        public bool UpdateWorkOrderConfirm(List<WorkOrderVO> wo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = new SqlConnection(this.ConnectionString);
                    cmd.Connection.Open();
                    foreach (var item in wo)
                    {
                        cmd.CommandText = "Update WorkOrder SET WO_State ='작업지시' where WO_ID = @WO_ID ";

                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@WO_ID", item.WO_ID);

                        cmd.ExecuteNonQuery();
                    }

                    cmd.Connection.Close();


                }

                return true;


            }
            catch (Exception err)
            {

                return false;
            }
        }

    }
}
