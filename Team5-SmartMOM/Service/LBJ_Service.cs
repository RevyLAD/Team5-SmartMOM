using Project_DAC;
using Project_DAC.LBJ;
using Project_VO;
using Project_VO.LBJ;
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
