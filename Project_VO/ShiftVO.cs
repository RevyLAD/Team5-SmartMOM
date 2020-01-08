using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_VO
{
    public class ShiftVO
    {
        public string Code { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string InputPeople { get; set; }
        public string UserOrNot { get; set; }
        public string Modifier { get; set; }
        public string ModifiyDate { get; set; }
        public string Others { get; set; }
    }
}
