using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_VO
{
    public class ShiftVO
    {
        public int SHIFT_ID { get; set; }
        public string FAC_Code { get; set; }
        public int SHIFT_StartTime { get; set; }
        public int SHIFT_EndTime { get; set; }
        public string SHIFT_StartDate { get; set; }
        public string SHIFT_EndDate { get; set; }
        public string SHIFT_InputPeople { get; set; }
        public string SHIFT_UserOrNot { get; set; }
        public string SHIFT_Modifier { get; set; }
        public string SHIFT_ModifiyDate { get; set; }
        public string SHIFT_Others { get; set; }
    }
}
