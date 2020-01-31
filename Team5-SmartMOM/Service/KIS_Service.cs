using Project_DAC;
using Project_VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5_SmartMOM.Service
{
    public class KIS_Service : ConnectionAccess
    {
        public List<BOM_VO> ShowBOM()
        {
            BOM_DAC cmd = new BOM_DAC();
            return cmd.ShowAllBOM();
        }

        public bool InsertBOM(BOM_VO list)
        {
            BOM_DAC cmd = new BOM_DAC();
            return cmd.InsertBOM(list);
        }
        public List<ITEM_VO> ShowITEM()
        {
            ITEM_DAC cmd = new ITEM_DAC();
            return cmd.ShowAllITEM();
        }
        public bool InsertItem(ITEM_VO list)
        {
            ITEM_DAC cmd = new ITEM_DAC();
            return cmd.InsertItem(list);
        }
        public bool DeleteItem(string list)
        {
            ITEM_DAC cmd = new ITEM_DAC();
            return cmd.DeleteItem(list);
        }
        public bool UpdateItem(ITEM_VO list)
        {
            ITEM_DAC cmd = new ITEM_DAC();
            return cmd.UpdateItem(list);
        }
        public bool DeleteBOM(string list)
        {
            BOM_DAC cmd = new BOM_DAC();
            return cmd.DeleteBOM(list);
        }

        public List<BOM_Serch_VO> SearchBOM(string name , int type)
        {
            BOM_DAC cmd = new BOM_DAC();
            return cmd.BOM_SearchData(name , type);
        }
        public List<ITEM_VO> GetAllCommonCode()
        {
            BOM_DAC dac = new BOM_DAC();
            return dac.GetAllCommonCode();
        }
        public List<BOM_VO1> GetAllCommonCode2()
        {
            BOM_DAC dac = new BOM_DAC();
            return dac.GetAllCommonCode2();
        }
    }
}
