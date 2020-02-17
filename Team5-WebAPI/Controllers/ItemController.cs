using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team5_WebAPI.DAC;
using Team5_WebAPI.Models;

namespace Team5_WebAPI.Controllers
{
    public class ItemController : Controller
    {
        List<Item_VO> list;
        // GET: Item
        public ActionResult Index()
        {
            string today = string.Empty;
            ViewBag.Today = DateTime.Now.ToString("yyyy-MM-dd");
            Item_DAC dac = new Item_DAC();
            list = dac.BOM_SearchData();

            var list2 = (from item in list
                         where item.ITEM_Type == "반제품"
                                                  select item).ToList();

            return View(list2);
        }

        public ActionResult Result(string id)
        {
            Item_DAC dac = new Item_DAC();
            list = dac.BOM_SearchData();
            List<Item_VO> resultInfo = (from item in list
                         where item.ITEM_Type == "원자재" &&item.BOM_Code ==id
                         select item).ToList();

            return View(resultInfo);
        }
    }
}