using Project_DAC;
using Project_VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5_SmartMOM.Service
{
    public class HSC_Service:ConnectionAccess
    {
        public List<FactoryVO> GetAllFactory()
        {
            FactoryDAC dac = new FactoryDAC();
            return dac.GetAllFactory();
        }

        public List<BORVO> GetAllBOR()
        {
            BORDAC dac = new BORDAC();
            return dac.GetAllBOR();
        }
    }
}
