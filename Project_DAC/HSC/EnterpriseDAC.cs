using Project_VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAC
{
    public class EnterpriseDAC : ConnectionAccess
    {
        public List<EnterpriseVO> GetAllEnterprise()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT COM_No, COM_Code, COM_Name, COM_Type, COM_Owner, COM_Sector, COM_Manager, COM_Email, " +
                    "COM_Phone, COM_UseOrNot, COM_Modifier, Convert(nvarchar(10),COM_ModifiyDate,23) COM_ModifiyDate, COM_Information from Company";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<EnterpriseVO> list = Helper.DataReaderMapToList<EnterpriseVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public void InsertEnterprise(EnterpriseVO evo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "Insert into Company(COM_No, [COM_Code], [COM_Name], [COM_Type], [COM_Owner], [COM_Sector], [COM_Manager], [COM_Email], [COM_Phone], [COM_UseOrNot], [COM_Modifier], [COM_ModifiyDate], [COM_Information]) values(@COM_No, @COM_Code, @COM_Name, @COM_Type, @COM_Owner, " +
                    "@COM_Sector, @COM_Manager, @COM_Email, @COM_Phone, @COM_UseOrNot, " +
                    "@COM_Modifier, @COM_ModifiyDate, @COM_Information)";

                cmd.Parameters.AddWithValue("@COM_No", evo.COM_No);
                cmd.Parameters.AddWithValue("@COM_Code", evo.COM_Code);
                cmd.Parameters.AddWithValue("@COM_Name", evo.COM_Name);
                cmd.Parameters.AddWithValue("@COM_Type", evo.COM_Type);
                cmd.Parameters.AddWithValue("@COM_Owner", evo.COM_Owner);
                cmd.Parameters.AddWithValue("@COM_Sector", evo.COM_Sector);
                cmd.Parameters.AddWithValue("@COM_Manager", evo.COM_Manager);
                cmd.Parameters.AddWithValue("@COM_Phone", evo.COM_Phone);
                cmd.Parameters.AddWithValue("@COM_Email", evo.COM_Email);
                cmd.Parameters.AddWithValue("@COM_UseOrNot", evo.COM_UseOrNot);
                cmd.Parameters.AddWithValue("@COM_Modifier", evo.COM_Modifier);
                cmd.Parameters.AddWithValue("@COM_ModifiyDate", evo.COM_ModifiyDate);
                cmd.Parameters.AddWithValue("@COM_Information", evo.COM_Information);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
    }
}
