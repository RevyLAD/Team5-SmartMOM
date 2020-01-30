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
        public List<ComPanyListVO> GetAllPurChasing()
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.GetAllPurChasing();
        }

        public List<PurchasingVO> GetAllPurChasingDetail(string query)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.GetAllPurChasingDetail(query);
        }

        public List<PurchasingStateVO> GetAllPurChasingState()
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.GetAllPurChasingState();
        }

        public List<CompanyCodeVO> GetAllCompanyCode()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetAllCompanyCode();
        }

        public List<CompanyCodeDetailVO> GetAllCompanyDetail(string query)
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetAllCompanyDetail(query);
        }

        public List<MATERIAL_ORDER_STATEVO> GetAllOrderState()
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.GetAllOrderState();
        }

        public bool VendorOrder(List<CodeVO> codelist)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.VendorOrder(codelist);
        }

        public bool EndDateChange(List<EndDateChange> datelist)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.EndDateChange(datelist);
        }

        public bool OrderDelete(List<DeleteOrder> deletelist)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.OrderDelete(deletelist);
        }

        public List<SupplierVO> Supplier()
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.Supplier();
        }

    }
}
