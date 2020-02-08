using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_VO
{
    public class Sales_VO
    {
        public int Sales_No { get; set; }
        public string COM_Code { get; set; }
        public string ITEM_Code { get; set; }
        public int Sales_Price_Now { get; set; }
        public int Sales_Price_Previous { get; set; }
        public DateTime Sales_StartDate { get; set; }
        public DateTime Sales_EndDate { get; set; }
        public string Sales_UseOrNot { get; set; }
        public string Sales_Editer { get; set; }
        public DateTime Sales_EditDate { get; set; }
        public string Sales_Others { get; set; }
    }
    public class Sales_VO_VIew
    {
        public int Sales_No { get; set; }
        public string COM_Code { get; set; }
        public string COM_Name { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_SIze { get; set; }
        public string ITEM_Unit { get; set; }
        public string Sales_Price_Now { get; set; }
        public string Sales_Price_Previous { get; set; }
        public DateTime Sales_StartDate { get; set; }
        public DateTime Sales_EndDate { get; set; }
        public string Sales_UseOrNot { get; set; }
        public string Sales_Editer { get; set; }
        public DateTime Sales_EditDate { get; set; }
        public string Sales_Others { get; set; }
    }
}
