using Project_DAC;
using Project_VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5_SmartMOM.Service
{
    public class PSM_Service : ConnectionAccess
    {
        public List<PurchasingVO> GetAllPurChasing()
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.GetAllPurChasing();
        }

        public List<PurchasingStateVO> GetAllPurChasingState()
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.GetAllPurChasingState();
        }
    }
}
