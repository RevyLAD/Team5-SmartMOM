using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_VO
{
    public class CommonCodeVO
    {
        public string Common_Type { get; set; }
        public string Common_Key { get; set; }
        public string Common_Value { get; set; }
    }

    public class CompanyCodeVO
    {
        public string COM_Code { get; set; }
        public string COM_Name { get; set; }
    }

    public class ItemCodeVO
    {
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
    }

    public class PlanIDVO
    {
        public string Plan_ID { get; set; }
    }

    public class FacGroupVO
    {
        public string FACG_Code { get; set; }
        public string FACG_Name { get; set; }
    }

    public class FacVO
    {
        public string FACT_Code { get; set; }
        public string FACT_Name { get; set; }
    }

    public class FacVOp
    {
        public string FAC_Name { get; set; }
        public string FAC_Code { get; set; }
        public string FACG_Code { get; set; }
    }

    public class CompanyCodeDetailVO
    {
        public string COM_Code { get; set; }
        public string COM_Name { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Type { get; set; }
        public string ITEM_Size { get; set; }
        public string COM_Owner { get; set; }
        public string COM_Phone { get; set; }
        public string COM_Information { get; set; }
    }

    public class ItemTypeVO
    {
        public string ITEM_Type { get; set; }
        
    }

    public class MATERIAL_ORDER_STATEVO
    {
        public string MATERIAL_ORDER_STATE { get; set; }
    }

}


