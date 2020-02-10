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

        public List<PurchasingStateVO> GetAllPurChasingState(PurchaseSearchVO ps)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.GetAllPurChasingState(ps);
        }

        public List<CompanyCodeVO> GetAllCompanyCode()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetAllCompanyCode();
        }

        public List<GetOrderVO> GetOrder(string plan_id)
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetOrder(plan_id);
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

        public bool VendorOrder(List<VendorOrderVO> codelist, string Plan_ID)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.VendorOrder(codelist, Plan_ID);
        }

        //납기일자변경
        public bool EndDateChange(List<EndDateChange> datelist)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.EndDateChange(datelist);
        }

        //발주취소
        public bool OrderDelete(List<DeleteOrder> deletelist)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.OrderDelete(deletelist);
        }

        //입고대기
        public bool OrderChange(List<DeleteOrder> lists)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.OrderChange(lists);
        }

        //입고대기취소
        public bool OrderCancel(List<DeleteOrder> lists)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.OrderCancel(lists); 
        }

        //입고대기
        public bool WarehousingWait(List<DeleteOrder> lists, List<VenderorderDetailVO> lists2)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.WarehousingWait(lists, lists2); 
        }

        public bool MaterialsPut(List<DeleteOrder> lists)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.MaterialsPut(lists); 
        }

        public bool MaterialsPutCancel(List<DeleteOrder> lists)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.MaterialsPutCancel(lists); 
        }


        public List<SupplierVO> Supplier(SupplierSearchVO sp)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.Supplier(sp);
        }

        public List<SupplierStateVO> SupplierState()
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.SupplierState();
        }

        public List<ImportCheckVO> ImportCheck(ImportCheckSearchVO ics)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.ImportCheck(ics);
        }

        public List<Material_LedgerVO> Material_Ledger(Material_LedgerSearchVO mls)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.Material_Ledger(mls);
        }

        public List<Receiving_processingVO> Receiving_processing()
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.Receiving_processing();
        }

        public bool Result(List<DeleteOrder> lists)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.Result(lists);
        }

        public List<MaterialsStateVO> MaterialsState(SupplierSearchVO sp)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.MaterialsState(sp);
        }

        public bool MaterialProcess(List<DeleteOrder> lists, List<MaterialsPlusVO> lists2)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.MaterialProcess(lists, lists2);
        }

        public bool MaterialCancel(List<DeleteOrder> lists, List<MaterialsPlusVO> lists2)
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.MaterialCancel(lists, lists2);
        }

        public List<Stock_StateVO> Stock_State()
        {
            PurchasingDAC dac = new PurchasingDAC();
            return dac.Stock_State();
        }

    }
}
