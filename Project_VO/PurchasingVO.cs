using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_VO
{
    public class PurchasingVO
    {
        public string COM_No { get; set; }
        public string COM_Code { get; set; }
        public string COM_Name { get; set; }
        public string ITEM_Code { get; set; }
        public int Vo_Quantity { get; set; }
        public DateTime Vo_EndDate { get; set; }
        public string ITEM_Size { get; set; }
        public string ITEM_ImportIns { get; set; }
        public string ITEM_OrderComp { get; set; }
        public int ITEM_MinOrderQuantity { get; set; }
    }

    public class ComPanyListVO
    {
        public string COM_No { get; set; }
        public string COM_Name { get; set; }
    }

    public class PurchasingStateVO
    {
        public int VO_ID { get; set; }
        public string COM_No { get; set; }
        public string MATERIAL_ORDER_STATE { get; set; }
        public int VO_Quantity { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public DateTime VO_EndDate { get; set; }
        public DateTime VO_StartDate { get; set; }
        public DateTime VO_InDate { get; set; }
        public string ITEM_Size { get; set; }
        public string ITEM_Unit { get; set; }
        public string COM_Code { get; set; }
        public string COM_Type { get; set; }
        public string COM_Name { get; set; }
    }

    public class VendorOrderVO
    {
        public string COM_Code { get; set; }
        public string MATERIAL_ORDER_STATE { get; set; }
        public string ITEM_Code { get; set; }
        public int VO_Quantity { get; set; }
        public DateTime VO_EndDate { get; set; }
        public DateTime VO_StartDate { get; set; }
        public DateTime VO_InDate { get; set; }
    }

    public class CodeVO
    {
        public string COM_Code { get; set; }
    }

    public class EndDateChange
    {
        public int VO_ID { get; set; }
        public DateTime VO_EndDate { get; set; }
    }

    public class DeleteOrder
    {
        public int VO_ID { get; set; }
    }

    public class SupplierVO
    {
        public int VO_ID { get; set; }
        public DateTime VO_StartDate { get; set; }
        public string ITEM_OrderComp { get; set; }
        public string COM_Code { get; set; }
        public string COM_Name { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Size { get; set; }
        public string ITEM_Unit { get; set; }
        public string ITEM_ImportIns { get; set; }
        public int VO_Quantity { get; set; }        
        public DateTime VO_EndDate { get; set; }        
        public string ITEM_OrderMethod { get; set; }

    }
}
