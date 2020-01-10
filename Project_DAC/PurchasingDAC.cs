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
    public class PurchasingDAC: ConnectionAccess
    {
        public List<PurchasingVO> GetAllPurChasing()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "Select COM_No, a.COM_Code, COM_Name, b.ITEM_Code, Vo_Quantity, Vo_EndDate, ITEM_Size, ITEM_ImportIns, " +
                    "ITEM_OrderComp, ITEM_MinOrderQuantity From Company a inner join VendorOrder b on a.COM_Code = b.COM_Code " +
                    "inner join ITEM c on b.ITEM_Code = c.ITEM_Code";                

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PurchasingVO> list = Helper.DataReaderMapToList<PurchasingVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<PurchasingStateVO> GetAllPurChasingState()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT VO_ID, MATERIAL_ORDER_STATE, VO_Quantity, a.ITEM_Code, VO_EndDate, VO_StartDate, " +
                    "VO_InDate, ITEM_Size, ITEM_Unit, c.COM_Code, COM_Type, COM_Name, COM_No " +
                    "FROM VendorOrder a inner join ITEM b on a.ITEM_Code = b.ITEM_Code " +
                    "inner join Company c on a.COM_Code = c.COM_Code";                

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PurchasingStateVO> list = Helper.DataReaderMapToList<PurchasingStateVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}
