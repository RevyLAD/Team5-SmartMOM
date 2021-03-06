﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_VO.HSM
{
    public class WorkOrderVO
    {
        public string WO_ID { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Name { get; set; }
        public string FAC_Name { get; set; }
        public string WO_StartDate { get; set; }
        public string WO_EndDate { get; set; }
        public int planQty { get; set; }
        public int directQty { get; set; }
        public string WO_State { get; set; }
        public string WO_OutState { get; set; }
        public string Plan_ID { get; set; }
        public int WO_Priority { get; set; }
        public int WO_Time { get; set; }
        public int WO_GoodQty { get; set; }
        public int WO_BadQty { get; set; }
        public DateTime WO_WorkEndTime { get; set; }
    }

    public class WorkOrderListVO
    {
        public string WO_StartDate { get; set; }
        public string WO_EndDate { get; set; }
        public string Plan_ID { get; set; }
        public string WO_State { get; set; }
    }

    public class WorkOrderStateVO
    {
        public string WO_State { get; set; }
    }

    public class SearchWorkOrderVO
    {
        public string Plan_ID { get; set; }
        public string WO_StartDate { get; set; }
        public string WO_EndDate { get; set; }
        public string WO_State { get; set; }
    }
}
