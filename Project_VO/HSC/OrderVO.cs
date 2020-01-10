using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_VO
{
    public class OrderVO
    {
        public int SO_WorkOrderID { get;set;}
        public string SO_PurchaseOrder { get;set;}
        public string COM_Code { get; set; }
        public string ITEM_Code { get; set; }
        public string SO_Duedate { get; set; }
        public int SO_Qty { get; set; }
        public int SO_ShipQty { get; set; }
        public string SO_Others { get; set; }
    }
}
