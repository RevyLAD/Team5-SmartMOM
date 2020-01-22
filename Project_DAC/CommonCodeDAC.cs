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



    }
}
