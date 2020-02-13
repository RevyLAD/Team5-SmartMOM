using Project_VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5_Pop
{
    public class PopService
    {
        public List<PopVO> PopGetData()
        {
            PopDAC dac = new PopDAC();
            return dac.PopGetData();
        }

        public List<FacGroupVO> GetFACGName()
        {
            PopDAC dac = new PopDAC();
            return dac.GetFACGName();
        }


        public List<FacVOp> GetFACName()
        {
            PopDAC dac = new PopDAC();
            return dac.GetFACName();
        }

        public void UpdateFacState(string name, string id)
        {
            PopDAC dac = new PopDAC();
            dac.UpdateFacState(name, id);
        }
        public string GetFacState(string name)
        {
            PopDAC dac = new PopDAC();
            return dac.GetFacState(name);
        }

        public string[] GetGaDongInfo(string name)
        {
            PopDAC dac = new PopDAC();
            return dac.GetGaDongInfo(name);
        }

        public string[] GetPlanTime(string name)
        {
            PopDAC dac = new PopDAC();
            return dac.GetPlanTime(name);
        }

        public string GetItemName(string code)
        {
            PopDAC dac = new PopDAC();
            return dac.GetItemName(code);
        }

        public int GetPortNum(string id)
        {
            PopDAC dac = new PopDAC();
            return dac.GetPortNum(id);
        }
    }
}
