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
    public class ImportDAC:ConnectionAccess
    {
        public List<ImportVO> Imports()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT a.VO_ID,c.COM_Name, b.ITEM_Code, d.ITEM_Size, a.VOD_Result, VOD_GoodEA, VOD_BadEA from VendorOrderDetail a inner join VendorOrder b on a.VO_ID = b.VO_ID inner join Company c on b.COM_Code = c.COM_Code inner join ITEM d on b.ITEM_Code = d.ITEM_Code";
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ImportVO> list = Helper.DataReaderMapToList<ImportVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public List<ImportSearch> ImportsSearch()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select a.VO_ID, INS_NAME, b.VOD_BadEA, c.ITEM_Code, d.ITEM_Size from Inspection a inner join VendorOrderDetail b on a.VO_ID = b.VO_ID inner join VendorOrder c on c.VO_ID = a.VO_ID inner join ITEM d on c.ITEM_Code = d.ITEM_Code";
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ImportSearch> list = Helper.DataReaderMapToList<ImportSearch>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
   
    }
}
