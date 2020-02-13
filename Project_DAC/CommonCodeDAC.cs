using Project_VO;
using Project_VO.HSM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAC
{
    public class CommonCodeDAC : ConnectionAccess
    {
        
        public List<CommonCodeVO> GetAllCommonCode()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select Common_Type, Common_Key, Common_Value from Common_Code ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CommonCodeVO> list = Helper.DataReaderMapToList<CommonCodeVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<CompanyCodeVO> GetAllCompanyCode()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select distinct COM_Code, COM_Name from Company ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CompanyCodeVO> list = Helper.DataReaderMapToList<CompanyCodeVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<CompanyCodeVO> GetAllCompanyCode2()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select distinct COM_Code, COM_Name from Company WHERE COM_Type = '고객사' ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CompanyCodeVO> list = Helper.DataReaderMapToList<CompanyCodeVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<PlanIDVO> PlanID()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select distinct Plan_ID from VendorOrder ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PlanIDVO> list = Helper.DataReaderMapToList<PlanIDVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<PlanIDVO> PlanID2()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select distinct Plan_ID from SalesMaster WHERE SALES_ORDER_STATE = '작업완료' ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PlanIDVO> list = Helper.DataReaderMapToList<PlanIDVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public List<CompanyCodeVO> GetCustomerCompanyCode()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select distinct COM_Code, COM_Name from Company WHERE COM_Type ='고객사' ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CompanyCodeVO> list = Helper.DataReaderMapToList<CompanyCodeVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<GetOrderVO> GetOrder(string plan_id)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetOrder";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Plan_ID", plan_id);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<GetOrderVO> list = Helper.DataReaderMapToList<GetOrderVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<CompanyCodeDetailVO> GetAllCompanyDetail(string query)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();

                cmd.CommandText = "select COM_Code, COM_Name, ITEM_Name,ITEM_Type, ITEM_Size, COM_Owner, COM_Phone, " +
                        "COM_Information from Company c , ITEM i where COM_No = @COM_No and c.COM_Code = i.ITEM_Code";

                cmd.Parameters.AddWithValue("@COM_No", query);
                

                SqlDataReader reader = cmd.ExecuteReader();
                List<CompanyCodeDetailVO> list = Helper.DataReaderMapToList<CompanyCodeDetailVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public List<ItemCodeVO> GetAllItemCode()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select distinct ITEM_Code, ITEM_Name from ITEM ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ItemCodeVO> list = Helper.DataReaderMapToList<ItemCodeVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<ItemTypeVO> GetAllItemType()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select distinct ITEM_Type from ITEM ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ItemTypeVO> list = Helper.DataReaderMapToList<ItemTypeVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<PlanIDVO> GetAllPlanID()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "  select distinct Plan_ID from salesmaster where Plan_ID is not null ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PlanIDVO> list = Helper.DataReaderMapToList<PlanIDVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<PlanIDVO> GetAllPlanID2()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "  select distinct Plan_ID from SalesMaster where Plan_ID is not null and Order_State = '발주대기'  ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PlanIDVO> list = Helper.DataReaderMapToList<PlanIDVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public List<PlanIDVO> GetPlanIDByWorkOrder()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = " select distinct Plan_ID from salesmaster where Plan_ID is not null and SALES_ORDER_STATE ='작업대기' ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PlanIDVO> list = Helper.DataReaderMapToList<PlanIDVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<PlanIDVO> GetPlanIDByWorkOrder2()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = " select distinct Plan_ID from salesmaster where Plan_ID is not null and SALES_ORDER_STATE ='작업생성' ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PlanIDVO> list = Helper.DataReaderMapToList<PlanIDVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<CommonCodeVO> GetFacilityClass()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select Common_Type, Common_Key, Common_Value from Common_Code where Common_Type = 'FACILITY_CLASS_ID'";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CommonCodeVO> list = Helper.DataReaderMapToList<CommonCodeVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }


        public List<CommonCodeVO> GetFacilityType()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select Common_Type, Common_Key, Common_Value from Common_Code where Common_Type = 'FACILITY_TYPE'";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CommonCodeVO> list = Helper.DataReaderMapToList<CommonCodeVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<CommonCodeVO> GetWareHouse1()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select Common_Type, Common_Key, Common_Value from Common_Code where Common_Type = 'FACILITY_TYPE' and ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CommonCodeVO> list = Helper.DataReaderMapToList<CommonCodeVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<CommonCodeVO> GetWareHouse2()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select Common_Type, Common_Key, Common_Value from Common_Code where Common_Type = 'FACILITY_TYPE'";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CommonCodeVO> list = Helper.DataReaderMapToList<CommonCodeVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<CommonCodeVO> GetUse()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select Common_Type, Common_Key, Common_Value from Common_Code where Common_Type = 'USE_FLAG'";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CommonCodeVO> list = Helper.DataReaderMapToList<CommonCodeVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<CommonCodeVO> GetOffer()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select Common_Type, Common_Key, Common_Value from Common_Code where Common_Type = 'FREE_OFFER'";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CommonCodeVO> list = Helper.DataReaderMapToList<CommonCodeVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }


        public List<CommonCodeVO> GetROUTE()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select Common_Type, Common_Key, Common_Value from Common_Code where Common_Type = 'ROUTE'";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CommonCodeVO> list = Helper.DataReaderMapToList<CommonCodeVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<CompanyCodeVO> GetCompanyList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select COM_Code, COM_Name from Company";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CompanyCodeVO> list = Helper.DataReaderMapToList<CompanyCodeVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<FacVO> GetFactoryList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select FACT_Code, FACT_Name from Factory";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<FacVO> list = Helper.DataReaderMapToList<FacVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }


        public List<CommonCodeVO> GetVENDOR()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select Common_Type, Common_Key, Common_Value from Common_Code where Common_Type = 'VENDOR_TYPE'";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CommonCodeVO> list = Helper.DataReaderMapToList<CommonCodeVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<PlanIDVO> GetPlanIDByDemandPlan()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "  select distinct Plan_ID from salesmaster where Plan_ID is not null and SALES_ORDER_STATE = '생산대기' ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PlanIDVO> list = Helper.DataReaderMapToList<PlanIDVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<PlanIDVO> GetPlanIDByProduction()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "  select distinct Plan_ID from salesmaster where Plan_ID is not null and SALES_ORDER_STATE = '작업대기' ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PlanIDVO> list = Helper.DataReaderMapToList<PlanIDVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public List<WorkOrderStateVO> GetWorkOrderState()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "  select distinct WO_State from WorkOrder  ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrderStateVO> list = Helper.DataReaderMapToList<WorkOrderStateVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<PlanIDVO> GetWorkOrderPlanID()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "  select distinct Plan_Id from WorkOrder  ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PlanIDVO> list = Helper.DataReaderMapToList<PlanIDVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

    }
}
