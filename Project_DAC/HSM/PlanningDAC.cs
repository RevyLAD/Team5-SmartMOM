using Project_VO.HSM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAC.HSM
{
    public class PlanningDAC : ConnectionAccess
    {
        public List<PlanningVO> GetAllSalesMaster()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PlanningVO> list = Helper.DataReaderMapToList<PlanningVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }


        public DataSet GetAllDemandPlan(PlanningVO plan)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();
                DataSet ds = new DataSet();
                cmd.CommandText = "GetDemandPlan";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StartDateTime",plan.SALES_OrderDate);
                cmd.Parameters.AddWithValue("@EndDateTime", plan.SALES_DueDate);

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds, "GetDemandPlan");

                cmd.Connection.Close();
                return ds;
               
            }
        }



        public DataSet GetAllDemandPlanByPlanID(PlanningVO plan)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();
                DataSet ds = new DataSet();
                cmd.CommandText = "GetDemandPlanByPlanID";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Plan_ID", plan.PlanId);
                cmd.Parameters.AddWithValue("@StartDateTime", plan.SALES_OrderDate);
                cmd.Parameters.AddWithValue("@EndDateTime", plan.SALES_DueDate);

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds, "GetDemandPlanByPlanID");

                cmd.Connection.Close();
                return ds;

            }
        }

        public DataSet GetMRP(PlanningVO plan)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();
                DataSet ds = new DataSet();
                cmd.CommandText = "MRP";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Plan_ID", plan.PlanId);
                cmd.Parameters.AddWithValue("@StartDateTime", plan.SALES_OrderDate);
                cmd.Parameters.AddWithValue("@EndDateTime", plan.SALES_DueDate);

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds, "GetMRP");

                cmd.Connection.Close();
                return ds;

            }
        }

        public DataSet GetProductPlan(PlanningVO plan)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();
                DataSet ds = new DataSet();
                cmd.CommandText = "GetProductPlan";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Plan_ID", plan.PlanId);
                cmd.Parameters.AddWithValue("@StartDateTime", plan.SALES_OrderDate);
                cmd.Parameters.AddWithValue("@EndDateTime", plan.SALES_DueDate);

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds, "GetProductPlan");

                cmd.Connection.Close();
                return ds;

            }
        }

    }
}
