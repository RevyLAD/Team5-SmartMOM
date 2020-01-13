using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_VO
{
    public class ITEM_VO
    {
        public int ITEM_No { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Size { get; set; }
        public string ITEM_Unit { get; set; }
        public string ITEM_Type { get; set; }
        public string ITEM_ImportIns { get; set; }
        public string ITEM_ProcessIns { get; set; }
        public string ITEM_ShipmentIns { get; set; }
        public string ITEM_OrderComp { get; set; }
        public string ITEM_InWarehouse { get; set; }
        public string ITEM_OutWarehouse { get; set; }
        public int ITEM_MinOrderQuantity { get; set; }
        public int ITEM_SafeQuantity { get; set; }
        public string ITEM_Grade { get; set; }
        public string ITEM_Manager { get; set; }
        public string ITEM_Modifier { get; set; }
        public DateTime ITEM_ModifiyDate { get; set; }
        public string ITEM_UserOrNot { get; set; }
        public string ITEM_OrderMethod { get; set; }
        public string ITEM_Others { get; set; }
    }
}
