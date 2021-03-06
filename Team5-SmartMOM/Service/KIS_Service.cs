﻿using Project_DAC;
using Project_VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public List<ITEM_VO> SearchITEM(string sb)
        {
            ITEM_DAC cmd = new ITEM_DAC();
            return cmd.SearchITEM(sb);
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

        public List<BOM_Serch_VO> SearchBOM(string name , int type ,string date)
        {
            BOM_DAC cmd = new BOM_DAC();
            return cmd.BOM_SearchData(name , type , date);
        }
        public List<ITEM_VO> GetAllCommonItem()
        {
            BOM_DAC dac = new BOM_DAC();
            return dac.GetAllCommonItem();
        }
        public List<BOM_VO> GetAllCommonBOM()
        {
            BOM_DAC dac = new BOM_DAC();
            return dac.GetAllCommonBOM();
        }
        public List<EnterpriseVO_Sales> GetAllCommonCode3()
        {
            BOM_DAC dac = new BOM_DAC();
            return dac.GetAllCommonCode4();
        }
        
        public List<Material_VO_VIew> ShowMaterial()
        {
            Matarial_DAC cmd = new Matarial_DAC();
            return cmd.ShowMaterial();
        }

        public SqlParameter InsertIMaterial(Material_VO list)
        {
            Matarial_DAC cmd = new Matarial_DAC();
            return cmd.InsertIMaterial(list);
        }
        public SqlParameter InsertISales(Sales_VO list)
        {
            Sales_DAC cmd = new Sales_DAC();
            return cmd.InsertISales(list);
        }

        public List<Sales_VO_VIew> ShowSales()
        {
            Sales_DAC cmd = new Sales_DAC();
            return cmd.ShowSales();
        }

        public List<Sales_VO_VIew> SearchSales(string date , string name)
        {
            Sales_DAC cmd = new Sales_DAC();
            return cmd.SearchSales(date , name);
        }
        
        public bool DeleteSales(string list)
        {
            Sales_DAC cmd = new Sales_DAC();
            return cmd.DeleteSales(list);
        }
        public List<Material_VO_VIew> SearchMaterial(string date, string name)
        {
            Matarial_DAC cmd = new Matarial_DAC();
            return cmd.SearchMaterial(date, name);
        }
        
        public bool DeleteMaterial(string list)
        {
            Matarial_DAC cmd = new Matarial_DAC();
            return cmd.DeleteMaterial(list);
        }
        public List<FactoryVO> GetAllFactoryCode()
        {
            ITEM_DAC dac = new ITEM_DAC();
            return dac.GetAllFactoryCode();
        }
    }
}
