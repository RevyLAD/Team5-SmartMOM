using Project_VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Project_DAC
{
    public class FactoryDAC:ConnectionAccess
    {
        public List<FactoryVO> GetAllFactory()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT FACT_No, FACT_Group, FACT_Class, FACT_Type, FACT_Code, FACT_Name, FACT_Parent, FACT_MATDeducation,FACT_UseOrNot,FACT_Modifier,FACT_ModifyDate,FACT_Information from Factory";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<FactoryVO> list = Helper.DataReaderMapToList<FactoryVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        //public List<FactoryVO> GetAllFactory()
        //{
        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        cmd.Connection = new SqlConnection(this.ConnectionString);
        //        cmd.CommandText = "SELECT ITEM_Code, FACG_Code, FAC_Code, BOR_TactTime, BOR_Priority, BOR_yeild, BOR_UseOrNot, BOR_Ohters from BOR";

        //        cmd.Connection.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        List<FactoryVO> list = Helper.DataReaderMapToList<FactoryVO>(reader);
        //        cmd.Connection.Close();

        //        return list;
        //    }
        //}

        public void InsertFactory(FactoryVO fvo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "Insert into Factory(" +
                    "FACT_Group, FACT_Class, FACT_Code, FACT_Name, FACT_Parent, " +
                    "FACT_MATDeducation, FACT_UseOrNot, FACT_Modifier, FACT_ModifyDate, " +
                    "FACT_Information) values(@FACT_Group, @FACT_Class, @FACT_Code, " +
                    "@FACT_Name, @FACT_Parent, @FACT_MATDeducation, @FACT_UseOrNot, " +
                    "@FACT_Modifier, @FACT_ModifyDate, @FACT_Information)";

                cmd.Parameters.AddWithValue("@FACT_Group", fvo.FACT_Group);
                cmd.Parameters.AddWithValue("@FACT_Class", fvo.FACT_Class);
                cmd.Parameters.AddWithValue("@FACT_Code", fvo.FACT_Code);
                cmd.Parameters.AddWithValue("@FACT_Name", fvo.FACT_Name);
                cmd.Parameters.AddWithValue("@FACT_Parent", fvo.FACT_Parent);
                cmd.Parameters.AddWithValue("@FACT_MATDeducation", fvo.FACT_MATDeducation);
                cmd.Parameters.AddWithValue("@FACT_UseOrNot", fvo.FACT_UseOrNot);
                cmd.Parameters.AddWithValue("@FACT_Modifier", fvo.FACT_Modifier);
                cmd.Parameters.AddWithValue("@FACT_ModifyDate", fvo.FACT_ModifyDate);
                cmd.Parameters.AddWithValue("@FACT_Information", fvo.FACT_Information);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        public List<FacGroupVO> GetAllFacilitesCode()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT FACG_Code, FACG_Name  from FacilityGroup";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<FacGroupVO> list = Helper.DataReaderMapToList<FacGroupVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public string GetModiTime(string code)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT FACT_ModifyDate from Factory where FACT_Code = @FACT_Code";

                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@FACT_Code", code);
                string result = Convert.ToString(cmd.ExecuteScalar());
                cmd.Connection.Close();

                return result;
            }
        }

        public void UpdateFactory(FactoryVO fvo, string code)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "update Factory Set " +
                    "FACT_Group=@FACT_Group, FACT_Class=@FACT_Class, FACT_Code=@FACT_Code, " +
                    "FACT_Name=@FACT_Name, FACT_Parent=@FACT_Parent, FACT_MATDeduction=@FACT_MATDeduction, " +
                    "FACT_UseOrNot=@FACT_UseOrNot, FACT_Modifier=@FACT_Modifier, FACT_ModifyDate=@FACT_ModifyDate, " +
                    "FACT_Information=@FACT_Information where @FACT_Code2";

                cmd.Parameters.AddWithValue("@FACT_Group", fvo.FACT_Group);
                cmd.Parameters.AddWithValue("@FACT_Class", fvo.FACT_Class);
                cmd.Parameters.AddWithValue("@FACT_Code", fvo.FACT_Code);
                cmd.Parameters.AddWithValue("@FACT_Name", fvo.FACT_Name);
                cmd.Parameters.AddWithValue("@FACT_Parent", fvo.FACT_Parent);
                cmd.Parameters.AddWithValue("@FACT_MATDeduction", fvo.FACT_MATDeducation);
                cmd.Parameters.AddWithValue("@FACT_UseOrNot", fvo.FACT_UseOrNot);
                cmd.Parameters.AddWithValue("@FACT_Modifier", fvo.FACT_Modifier);
                cmd.Parameters.AddWithValue("@FACT_ModifyDate", fvo.FACT_ModifyDate);
                cmd.Parameters.AddWithValue("@FACT_Information", fvo.FACT_Information);

                cmd.Parameters.AddWithValue("@FACT_Code2", code);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
    }
}
