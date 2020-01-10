using Project_VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAC
{
    public class OrderDAC:ConnectionAccess
    {
        public List<OrderVO> GetAllOrder()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT SO_WorkOrderID, SO_PurchaseOrder, COM_Name, i.ITEM_Code, SO_Duedate, SO_Qty, SO_ShipQty, SO_Others from SalesOrder s, Company c, ITEM i where c.COM_Code = s.COM_Code and s.ITEM_Code = i.ITEM_Code";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<OrderVO> list = Helper.DataReaderMapToList<OrderVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}
