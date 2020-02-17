using Project_VO.LBJ;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAC.LBJ
{
    public class StockStateDAC : ConnectionAccess
    {
        public List<StockStateVO> StockState()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = @"select InOut_No, A.InOut_Date, InOut_Gubun, InOut_Category ,From_WareHouse, In_WareHouse, A.ITEM_Code, InOut_Qty, B.ITEM_Name, ITEM_Size, ITEM_Type " +
                                                     " from InOutList A inner join ITEM B on A.ITEM_Code = B.ITEM_Code";
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<StockStateVO> StockList = Helper.DataReaderMapToList<StockStateVO>(reader);
                cmd.Connection.Close();

                return StockList;
            }
        }
    }
}
