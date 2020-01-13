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
    public class ShiftDAC:ConnectionAccess
    {
        public List<ShiftVO> Shift()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT SHIFT_ID, FAC_Code ,SHIFT_StartTime, SHIFT_EndTime, SHIFT_StartDate, SHIFT_EndDate, SHIFT_InputPeople, SHIFT_UserOrNot, SHIFT_Modifier, SHIFT_ModifierDate, SHIFT_Others FROM Shift";
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
                cmd.CommandText = "select SHIFT_ID, a.SHIFT_StartTime, SHIFT_EndTime, SHIFT_InputPeople, b.FAC_Name from Shift A inner join Facility b on a.FAC_Code = b.FAC_Code where a.FAC_Code = 1";
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ShiftManagementVO> list = Helper.DataReaderMapToList<ShiftManagementVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}
