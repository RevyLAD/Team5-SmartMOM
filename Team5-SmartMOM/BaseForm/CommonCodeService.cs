using Project_DAC;
using Project_VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5_SmartMOM.BaseForm
{
    public class CommonCodeService
    {
        public List<CommonCodeVO> GetAllCommonCode()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetAllCommonCode();
        }

        public List<CompanyCodeVO> GetAllCompanyCode()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetAllCompanyCode();
        }

        public List<ItemCodeVO> GetAllItemCode()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetAllItemCode();
        }

        public List<PlanIDVO> GetAllPlanID()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetAllPlanID();
        }

         public List<CommonCodeVO> GetFacilityClass()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetFacilityClass();
        }

        public List<CommonCodeVO> GetFacilityType()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetFacilityType();
        }

        public List<CommonCodeVO> GetROUTE()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetROUTE();
        }

        public List<CommonCodeVO> GetUse()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetUse();
        }

        public List<CommonCodeVO> GetOffer()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetOffer();
        }
        public List<CompanyCodeVO> GetCompanyList()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetCompanyList();
        }

        public List<FacVO> GetFactoryList()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetFactoryList();
        }

    }
}
