using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5_Pop
{
    public class PopVO
    {
        public string WO_ID { get; set; }
        public string ITEM_Code { get; set; }
        public string FAC_Name { get; set; }
        public DateTime WO_StartDate { get; set; }
        public DateTime WO_EndDate { get; set; }
        public int planQty { get; set; }
        public int directQty { get; set; }
        public string WO_State { get; set; }
        public string Plan_ID { get; set; }
        public int WO_Priority { get; set; }
        public int WO_Time { get; set; }
        public int restQty { get; set; }
    }

    public class PoPLogVO
    {
        public string WO_ID { get; set; }
        public string FAC_Name { get; set; }
        public string ITEM_Code { get; set; }
        public DateTime ProductTime { get; set; }
        public string Qty { get; set; }
    }
    public class ControlVO
    {
        public string WO_ID { get; set; }
        public string FAC_Name { get; set; }
        public string ITEM_Code { get; set; }
        public int directQty { get; set; }
        public int GoodQty { get; set; }
        public int BadQty { get; set; }
    }

    public class NewControlVO
    {
        public string WO_ID { get; set; }
        public string FAC_Name { get; set; }
    }

    public class PoPEndVO
    {
        public string WO_ID { get; set; }
        public string WO_State { get; set; }
        public int GoodQty { get; set; }
        public int BadQty { get; set; }
        public int restQty { get; set; }
        public DateTime WO_WorkEndTime{ get; set; }
    }
}