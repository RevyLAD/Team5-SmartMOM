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

        public List<EnterpriseVO> GetAllEnterprise()
        {
            EnterpriseDAC dac = new EnterpriseDAC();
            return dac.GetAllEnterprise();
        }

        public List<FacilitieDetailVO> GetAllFacilitiesDetail()
        {
            FacilitieDAC dac = new FacilitieDAC();
            return dac.GetAllFacilitiesDetail();
        }
        public List<FacilitieVO> GetAllFacilities()
        {
            FacilitieDAC dac = new FacilitieDAC();
            return dac.GetAllFacilities();
        }

        public List<OrderVO> GetAllOrder()
        {
            OrderDAC dac = new OrderDAC();
            return dac.GetAllOrder();
        }

        public void InsertFactory(FactoryVO fvo)
        {
            FactoryDAC dac = new FactoryDAC();
            dac.InsertFactory(fvo);
        }

        public List<FacGroupVO> GetAllFacilitesCode()
        {
            FactoryDAC dac = new FactoryDAC();
            return dac.GetAllFacilitesCode();
        }

        public string GetModiTime(string code)
        {
            FactoryDAC dac = new FactoryDAC();
            return dac.GetModiTime(code);
        }

        public void UpdateFactory(FactoryVO fvo, string code)
        {
            FactoryDAC dac = new FactoryDAC();
            dac.UpdateFactory(fvo, code);
        }

        public void InsertBOR(BORVO bvo)
        {
            BORDAC dac = new BORDAC();
            dac.InsertBOR(bvo);
        }

        public void InsertEnterprise(EnterpriseVO evo)
        {
            EnterpriseDAC dac = new EnterpriseDAC();
            dac.InsertEnterprise(evo);
        }

        public void InsertFacilities(FacilitieVO vo)
        {
            FacilitieDAC dac = new FacilitieDAC();
            dac.InsertFacilities(vo);
        }

        public void InsertFacilitieDetail(FacilitieDetailVO vo)
        { 
            FacilitieDAC dac = new FacilitieDAC();
            dac.InsertFacilitieDetail(vo);
        }

        public List<FacilitieDetailVO> FindFacDetail(string Code)
        {
            FacilitieDAC dac = new FacilitieDAC();
            return dac.FindFacDetail(Code);
        }

        public void DeleteBOR(int Code)
        {
            BORDAC dac = new BORDAC();
            dac.DeleteBOR(Code);
        }

        public void DeleteFacT(int id)
        {
            FacilitieDAC dac = new FacilitieDAC();
            dac.DeleteFacT(id);
        }

        public void DeleteFacDetail(int id)
        {
            FacilitieDAC dac = new FacilitieDAC();
            dac.DeleteFacDetail(id);
        }

        public void DeleteEnt(string id)
        {
            EnterpriseDAC dac = new EnterpriseDAC();
            dac.DeleteEnt(id);
        }

        public void UpdateEnterprise(EnterpriseVO vo)
        {
            EnterpriseDAC dac = new EnterpriseDAC();
            dac.UpdateEnterprise(vo);
        }

        public void UpdateBOR(BORVO bvo)
        {
            BORDAC dac = new BORDAC();
            dac.UpdateBOR(bvo);
        }
    }
}
