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
    public class ImportDAC : ConnectionAccess
    {
        public List<ImportVO> Imports()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select a.VO_ID, VOD_Result, VOD_BadEA, VOD_GoodEA, VOD_ResultDay, b.ITEM_Code, c.ITEM_Name, ITEM_Size, d.COM_Name from VendorOrderDetail a inner join VendorOrder b on a.VO_ID = b.VO_ID inner join ITEM c on b.ITEM_Code = c.ITEM_Code inner join Company d on b.COM_Code = d.COM_Code";
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
