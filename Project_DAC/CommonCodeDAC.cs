using Project_VO;
using System;
using System.Collections.Generic;
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
    }
}
