using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team5_WebAPI.Models
{
    public class Sales_VO
    {
        public string COM_Code { get; set; }
        public string Sales_Editer { get; set; }
        public string Sales_Price_Now { get; set; }
        public int Sales_StartDate { get; set; }
        public DateTime Sales_EditDate { get; set; }
    }
}