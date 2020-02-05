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
        public List<WorkOrderVO> GetWorkOrderByPlan()
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
        public List<WorkOrderVO> GetWorkOrderByPlanId(string planId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = @"select WO_ID,w.Item_code,Item_Name, Fac_Name, CONVERT(nvarchar(10),WO_Startdate,23) WO_Startdate , CONVERT(nvarchar(10),WO_EndDate,23) WO_EndDate,
                                    planQty, directQty, Wo_state, plan_ID, WO_Priority, WO_Time
                                    from WorkOrder w , Item i
                                    where Plan_Id = @Plan_Id
                                    and WO_State = '작업생성'
                                    and w.Item_code = i.ITEM_Code ";

                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@Plan_Id", planId);

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
