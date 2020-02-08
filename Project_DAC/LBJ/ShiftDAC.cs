using Project_VO.HSM;
using Project_VO.LBJ;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAC.LBJ
{
    public class ShiftDAC : ConnectionAccess
    {
        public List<ShiftVO> Shift()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT SHIFT_ID, FAC_Code ,SHIFT_StartTime, SHIFT_EndTime, SHIFT_StartDate, SHIFT_EndDate, SHIFT_InputPeople, SHIFT_UserOrNot,   SHIFT_Modifier, SHIFT_ModifierDate, SHIFT_Others, SHIFT FROM Shift";
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ShiftVO> list = Helper.DataReaderMapToList<ShiftVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public List<ShiftManagementVO> ShiftManage()
        {
           
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(this.ConnectionString);
                    cmd.CommandText = "select SHIFT_ID, A.SHIFT, SHIFT_StartDate, SHIFT_EndDate, B.FAC_Name from Shift A inner join Facility B on A.FAC_Code = B.FAC_Code";

                    //select SHIFT_ID, a.SHIFT_StartTime, SHIFT_EndTime, SHIFT_InputPeople, b.FAC_Name from Shift A inner join Facility b on a.FAC_Code = b.FAC_Code where a.FAC_Code = 1


                    cmd.Connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<ShiftManagementVO> list = Helper.DataReaderMapToList<ShiftManagementVO>(reader);
                    cmd.Connection.Close();

                    return list;
                }
        }
        public void ShiftInsert(ShiftVO svo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "INSERT INTO Shift(SHIFT, FAC_Code ,SHIFT_StartTime, SHIFT_EndTime, SHIFT_StartDate, SHIFT_EndDate, SHIFT_InputPeople, SHIFT_UserOrNot,   SHIFT_Modifier, SHIFT_ModifierDate, SHIFT_Others) VALUES(@SHIFT, @FAC_Code ,@SHIFT_StartTime, @SHIFT_EndTime, @SHIFT_StartDate, @SHIFT_EndDate, @SHIFT_InputPeople, @SHIFT_UserOrNot, @SHIFT_Modifier, @SHIFT_ModifierDate, @SHIFT_Others)";

                cmd.Parameters.AddWithValue("@SHIFT", svo.SHIFT);
                cmd.Parameters.AddWithValue("@FAC_Code", svo.FAC_Code);
                cmd.Parameters.AddWithValue("@SHIFT_StartTime", svo.SHIFT_StartTime);
                cmd.Parameters.AddWithValue("@SHIFT_EndTime", svo.SHIFT_EndTime);
                cmd.Parameters.AddWithValue("@SHIFT_StartDate", svo.SHIFT_StartDate);
                cmd.Parameters.AddWithValue("@SHIFT_EndDate", svo.SHIFT_EndDate);
                cmd.Parameters.AddWithValue("@SHIFT_InputPeople", svo.SHIFT_InputPeople);
                cmd.Parameters.AddWithValue("@SHIFT_UserOrNot", svo.SHIFT_UserOrNot);
                cmd.Parameters.AddWithValue("@SHIFT_Modifier", svo.SHIFT_Modifier);
                cmd.Parameters.AddWithValue("@SHIFT_ModifierDate", svo.SHIFT_ModifierDate);
                cmd.Parameters.AddWithValue("@SHIFT_Others", svo.SHIFT_Others);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.Connection.Close();
            }
        }
        public DataSet GetShiftManagement(ShiftManagementVO mvo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();
                DataSet ds = new DataSet();
                cmd.CommandText = "ShiftManagement";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StartDateTime", mvo.SHIFT_StartDate);
                cmd.Parameters.AddWithValue("@EndDateTime", mvo.SHIFT_EndDate);

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds, "ShiftManagement");

                cmd.Connection.Close();
                return ds;

            }
        }
        public bool DeleteShift(string list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "Delete From Shift where SHIFT_ID in ( " + list + ")";

                cmd.Connection.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rowsAffected > 0;
            }
        }
    }
}
