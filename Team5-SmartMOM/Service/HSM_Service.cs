using Project_DAC.HSM;
using Project_VO.HSM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5_SmartMOM.Service
{
    public class HSM_Service
    {
        public bool UploadSalesMaster(List<SalesMasterVO> sales)
        {
            SalesMasterDAC dac = new SalesMasterDAC();
            return dac.UploadSalesMaster(sales);
        }

        public bool UploadPassiveSalesMaster(SalesMasterAllVO sales)
        {
            SalesMasterDAC dac = new SalesMasterDAC();
            return dac.UploadPassiveSalesMaster(sales);
        }

        public List<SalesMasterAllVO> GetAllSalesMaster()
        {
            SalesMasterDAC dac = new SalesMasterDAC();
            return dac.GetAllSalesMaster();
        }
    }
}
