using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_VO.LBJ
{
    public class MateriaVO
    {
        public DateTime WO_StartDate { get; set; }
        public string WO_ID { get; set; }
        public string FAC_Name { get; set; }
        public string FAC_OutWareHouse { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public int PlanQty { get; set; }
        public string ITEM_Unit { get; set; }
        public string WO_State { get; set; }        
    }
    public class MateriaRequestVO
    {
        public string ITEM_Code { get; set; }
        public string WO_ID { get; set; }
        public string FAC_Name { get; set; }
        public DateTime WO_StartDate { get; set; }
        public DateTime WO_EndDate { get; set; }
    }
    public class MateriaenVO
    {
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string ITEM_Size { get; set; }
        public string FAC_OutWareHouse { get; set; }
        public DateTime WO_StartDate { get; set; }
        public int planQty { get; set; }
    }
}


