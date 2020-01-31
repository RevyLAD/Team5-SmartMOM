using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_VO
{
    public class BOM_VO
    {
        public int BOM_No { get; set; }
        public string BOM_Code { get; set; }
        public string ITEM_Code { get; set; }
        public int BOM_Require { get; set; }
        public DateTime BOM_StartDate { get; set; }
        public DateTime BOM_EndDate { get; set; }
        public string BOM_UseOrNot { get; set; }
        public string BOM_Modifier { get; set; }
        public DateTime BOM_ModifiyDate { get; set; }
        public string BOM_AutoDeduction { get; set; }
        public string BOM_RequirePlan { get; set; }
        public string BOM_Others { get; set; }
    }
    public class BOM_VO1
    {
        public int BOM_No { get; set; }
        public string BOM_Code { get; set; }
        public string ITEM_Code { get; set; }
        public int BOM_Require { get; set; }
        public DateTime BOM_StartDate { get; set; }
        public DateTime BOM_EndDate { get; set; }
        public string BOM_UseOrNot { get; set; }
        public string BOM_Modifier { get; set; }
        public DateTime BOM_ModifiyDate { get; set; }
        public string BOM_AutoDeduction { get; set; }
        public string BOM_RequirePlan { get; set; }
        public string BOM_Others { get; set; }
        public string ITEM_Type { get; set; }
    }
}
