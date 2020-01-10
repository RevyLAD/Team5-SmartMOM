using Project_DAC;
using Project_VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5_SmartMOM.Service
{
    public class LBJ_Service:ConnectionAccess
    {
        public List<ShiftVO> Shift()
        {
            ShiftDAC dac = new ShiftDAC();
            return dac.Shift();
        }
    }
}
