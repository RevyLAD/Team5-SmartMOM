using Project_DAC.HSM;
using Project_VO.HSM;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<WorkOrderVO> GetWorkOrderByPlanId(string planId)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetWorkOrderByPlanId(planId);
        }

        public bool InsertWorkOrder(string planId)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.InsertWorkOrder(planId);
        }

        public List<SalesMasterAllVO> GetAllSalesMaster()
        {
            SalesMasterDAC dac = new SalesMasterDAC();
            return dac.GetAllSalesMaster();
        }
        public List<SalesMasterWorkOrder> GetSalesMasterByPlanID(string planId)
        {
            SalesMasterDAC dac = new SalesMasterDAC();
            return dac.GetSalesMasterByPlanID(planId);
        }
        

        public DataSet GetAllDemandPlan(PlanningVO plan)
        {
            PlanningDAC dac = new PlanningDAC();
            return dac.GetAllDemandPlan(plan);
        }
        public DataSet GetAllDemandPlanByPlanID(PlanningVO plan)
        {
            PlanningDAC dac = new PlanningDAC();
            return dac.GetAllDemandPlanByPlanID(plan);
        }

        public DataSet GetMRP(PlanningVO plan)
        {
            PlanningDAC dac = new PlanningDAC();
            return dac.GetMRP(plan);
        }

        public DataSet GetProductPlan(PlanningVO plan)
        {
            PlanningDAC dac = new PlanningDAC();
            return dac.GetProductPlan(plan);
        }


        public bool UpdatePlanID(List<UpdatePlanIDVO> plan)
        {
            SalesMasterDAC dac = new SalesMasterDAC();
            return dac.UpdatePlanID(plan);
        }

        public bool UpdatePlanID(string workId)
        {
            SalesMasterDAC dac = new SalesMasterDAC();
            return dac.UpdatePlanID(workId);
        }
    }
}
