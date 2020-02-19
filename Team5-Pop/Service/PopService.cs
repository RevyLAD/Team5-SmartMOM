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

        public List<PopVO> GetPoPVOByWoId(string WoId)
        {
            PopDAC dac = new PopDAC();
            return dac.GetPoPVOByWoId(WoId);
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

        public string GetFACNameByWoId(string woId)
        {
            PopDAC dac = new PopDAC();
            return dac.GetFACNameByWoId(woId);
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

        public void SavePopData(List<string> list)
        {
            PopDAC dac = new PopDAC();
            dac.SavePopData(list);
        }

        public void WritePoPLog(PoPLogVO logvo)
        {
            PopDAC dac = new PopDAC();
            dac.WritePoPLog(logvo);
        }

        public List<ControlVO> GetInfoForControl(string name, string id)
        {
            PopDAC dac = new PopDAC();
            return dac.GetInfoForControl(id, name);
        }

        public string GetFACSignal(string FacName)
        {
            PopDAC dac = new PopDAC();
            return dac.GetFACSignal(FacName);
        }

        public List<NewControlVO> GetNewControl()
        {
            PopDAC dac = new PopDAC();
            return dac.GetNewControl();
        }

        public string GetWO_ID(string FacName)
        {
            PopDAC dac = new PopDAC();
            return dac.GetWO_ID(FacName);
        }

        public void UpdateFacStateEnd(string FacName)
        {
            PopDAC dac = new PopDAC();
            dac.UpdateFacStateEnd(FacName);
        }

        public void UpdateFacStatePause(string FacName, int choice)
        {
            PopDAC dac = new PopDAC();
            dac.UpdateFacStatePause(FacName, choice);
        }
    }
}
