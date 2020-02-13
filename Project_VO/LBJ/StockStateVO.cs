using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_VO.LBJ
{
    public class StockStateVO
    {
        public int InOut_No { get; set; }
        public DateTime InOut_Date { get; set; }
        public string InOut_Gubun { get; set; }
        public string InOut_Category { get; set; }
        public string From_WareHouse { get; set; }
        public string In_WareHouse { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Size { get; set; }
        public string ITEM_Type { get; set; }
        public int InOut_Qty { get; set; }
    }
}
