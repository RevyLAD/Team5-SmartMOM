using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_VO.LBJ
{
    public class ImportVO
    {
        public int VO_ID { get; set; }
        public string COM_Name { get; set; }
        public string ITEM_Code { get; set; }
        public string ITEM_Size { get; set; }
        public string VOD_Result { get; set; }
        public int VOD_GoodEA { get; set; }
        public int VOD_BadEA { get; set; }
    }
}
