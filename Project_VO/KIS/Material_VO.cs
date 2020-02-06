using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_VO
{
    public class Material_VO
    {
        public int Material_No { get; set; }
        public string COM_Code { get; set; }
        public string ITEM_Code { get; set; }
        public int Material_Price_Now { get; set; }
        public int Material_Price_Previous { get; set; }
        public DateTime Material_StartDate { get; set; }
        public DateTime Material_EndDate { get; set; }
        public string Material_Editer { get; set; }
        public string Material_UseOrNot{ get; set; }
        public DateTime Material_EditDate { get; set; }
        public string Material_Others { get; set; }
    }
    public class Material_VO_VIew
    {
        public int Material_No { get; set; }
        public string COM_Code { get; set; }
        public string COM_Name { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_SIze { get; set; }
        public string ITEM_Unit { get; set; }
        public string Material_Price_Now { get; set; }
        public string Material_Price_Previous { get; set; }
        public DateTime Material_StartDate { get; set; }
        public DateTime Material_EndDate { get; set; }
        public string Material_Editer { get; set; }
        public string Material_UseOrNot { get; set; }
        public DateTime Material_EditDate { get; set; }
        public string Material_Others { get; set; }
    }
}
