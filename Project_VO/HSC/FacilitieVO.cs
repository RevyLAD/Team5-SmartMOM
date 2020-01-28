using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_VO
{
    public class FacilitieVO
    {
        public int FACG_No { get; set; }
        public string FACG_Code { get; set; }
        public string FACG_Name { get; set; }
        public string FACG_UseOrNot { get; set; }
        public string FACG_Modifier { get; set; }
        public DateTime FACG_ModifyDate { get; set; }
        public string FACG_Information { get; set; }
    }

    public class FacilitieDetailVO
    {
        public int FAC_No { get; set; }
        public string FACG_Code { get; set; }
        public string FAC_Code { get; set; }
        public string FAC_Name { get; set; }
        public string FAC_OutWareHouse { get; set; }
        public string FAC_InWareHouse { get; set; }
        public string FAC_BadWareHouse { get; set; }
        public string FAC_UseOrNot { get; set; }
        public string FAC_Modifier { get; set; }
        public DateTime FAC_ModifiyDate { get; set; }
        public string FAC_Remark { get; set; }
        public string FAC_Others { get; set; }
    }
}
