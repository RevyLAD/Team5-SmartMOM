using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_VO.HSM
{
    public class SalesMasterVO
    {
        public string SO_WorkOrderID { get; set; }
        public string COM_Code { get; set; }
        public string ITEM_Code { get; set; }
        public string PO_Type { get; set; }
        public int SALES_OrderQty { get; set; }
        public string SALES_Duedate { get; set; }
        public string SALES_OrderDate { get; set; }

    }

    public class SalesMasterAllVO
    {
        public string SO_WorkOrderID { get; set; }
        public string COM_Code { get; set; }
        public string COM_Name { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string PO_Type { get; set; }
        public int SALES_OrderQty { get; set; }
        public int SALES_ShipQty { get; set; }
        public int SALES_CancelQty { get; set; }
        public string SALES_Duedate { get; set; }
        public string SALES_OrderDate { get; set; }
        public string SALES_Remark { get; set; }
    }
}
