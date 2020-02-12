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
        public string Plan_ID { get; set; }
        public string COM_Code { get; set; }
        public string COM_Name { get; set; }
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
        public string MATERIAL_ORDER_STATE { get; set; }
    }

    public class SupplierStateVO
    {
        public int VO_ID { get; set; }
        public DateTime VO_StartDate { get; set; }
        public string COM_Code { get; set; }
        public string COM_Name { get; set; }
        public string COM_Type { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Size { get; set; }
        public string ITEM_Unit { get; set; }
        public int VO_Quantity { get; set; }
        public DateTime VO_EndDate { get; set; }
        public DateTime VO_InDate { get; set; }
        public string MATERIAL_ORDER_STATE { get; set; }
        public int FACD_Qty { get; set; }
        public string FACT_Name { get; set; }
    }

    public class ImportCheckVO
    {
        public int VO_ID { get; set; }
        public string COM_Name { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Size { get; set; }
        public string VOD_Result { get; set; }
        public int VOD_GoodEA { get; set; }
        public int VOD_BadEA { get; set; }
        public DateTime VOD_ResultDay { get; set; }

    }

    public class VenderorderDetailVO
    {
        public int VO_ID { get; set; }
        public int VOD_GoodEA { get; set; }
        public int VOD_BadEA { get; set; }
        public DateTime VO_StartDate { get; set; }
        public string VOD_Result { get; set; }
    }

    public class Material_LedgerVO
    {
        public int VO_ID { get; set; }
        public string COM_Name { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Size { get; set; }
        public string ITEM_Unit { get; set; }
        public int VOD_GoodEA { get; set; }
        public int FACD_Qty { get; set; }
        public DateTime VO_EndDate { get; set; }
        public string VOD_Result { get; set; }
        public string MATERIAL_ORDER_STATE { get; set; }
        public DateTime VOD_ResultDay { get; set; }        
    }

    public class Receiving_processingVO
    {
        public int VO_ID { get; set; }        
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Size { get; set; }
        public string ITEM_Type { get; set; }
        public string ITEM_Unit { get; set; }
        public string FACT_Name { get; set; }
        public DateTime VO_InDate { get; set; }
        public int ITEM_Price { get; set; }
        public int VOD_GoodEA { get; set; }
    }       

    public class MaterialsStateVO
    {
        public int VO_ID { get; set; }
        public DateTime VO_InDate { get; set; }
        public string FACT_Name { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Size { get; set; }
        public string ITEM_Unit { get; set; }
        public int VOD_GoodEA { get; set; }
        public int FACD_Qty { get; set; }
        public string COM_Name { get; set; }
    }

    public class MaterialsPlusVO
    {
        public int VOD_GoodEA { get; set; }
        public string ITEM_Code { get; set; }
    }

    public class Stock_StateVO
    {
        public string FACT_Code { get; set; }
        public string FACT_Name { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Type { get; set; }
        public string ITEM_Size { get; set; }
        public int FACD_Qty { get; set; }
        public string ITEM_Unit { get; set; }
    }

    public class PurchaseSearchVO
    {
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string Company { get; set; }
        public string Item { get; set; }
        public string State { get; set; }
        public int VO_ID { get; set; }
        public string Plan_ID { get; set; }
    }

    public class SupplierSearchVO
    {
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string Company { get; set; }
        public string Item { get; set; }        
        public string Plan_ID { get; set; }
    }

    public class ImportCheckSearchVO
    {
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string Company { get; set; }
        public string Item { get; set; }
        public string Result { get; set; }
        public string Plan_ID { get; set; }
    }

    public class Material_LedgerSearchVO
    {
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string Company { get; set; }
        public string Item { get; set; }      
        public string Plan_ID { get; set; }
    }

    public class MaterialInDateVO
    {
        public int VO_ID { get; set; }
        public DateTime VO_InDate { get; set; }
    }

    public class MaterialStateVO
    {
        public string FACT_Name { get; set; }
        public string ITEM_Name { get; set; }
    }

    public class InOutListVO
    {        
        public DateTime InOut_Date { get; set; }
        public string InOut_Gubun { get; set; }
        public string InOut_Category { get; set; }
        public string From_WareHouse { get; set; }
        public string In_WareHouse { get; set; }
        public string ITEM_Code { get; set; }
        public int InOut_Qty { get; set; }
    }


}
