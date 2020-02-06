using Project_DAC;
using Project_DAC.LBJ;
using Project_VO;
using Project_VO.HSM;
using Project_VO.LBJ;
using System;
using System.Collections.Generic;
using System.Data;
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
        public List<ShiftManagementVO> ShiftManage()
        {
            ShiftDAC dac = new ShiftDAC();
            return dac.ShiftManage();
        }
        public List<ImportVO> Imports()
        {
            ImportDAC dac = new ImportDAC();
            return dac.Imports();
        }
        public List<ImportSearch> ImportSearch()
        {
            ImportDAC dac = new ImportDAC();
            return dac.ImportsSearch();
        }
        public void ShiftInsert(ShiftVO svo)
        {
            ShiftDAC dac = new ShiftDAC();
            dac.ShiftInsert(svo);
        }
        public DataSet GetShiftManagement(ShiftManagementVO mvo)
        {
            ShiftDAC dac = new ShiftDAC();
            return dac.GetShiftManagement(mvo);
        }
        //public DataSet GetAllDemandPlanByPlanID(ManagementVO management, PlanningVO plan)
        //{
        //    ShiftDAC dac = new ShiftDAC();
        //    return dac.GetAllDemandPlanByPlanID(management, plan);
        //}
    }
}
