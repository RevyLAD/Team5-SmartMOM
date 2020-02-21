using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team5_WebAPI.Models
{
    public class WorkOrder_VO
    {
        public string FAC_Name { get; set; }
        public int B_Qty { get; set; }
        public int Q_qty { get; set; }
        public double G_QtyMIN { get; set; }
        public double B_QtyMIN { get; set; }
    }
    public class WorkOrder_VO2
    {
        public int Allcount { get; set; }
    }
    }