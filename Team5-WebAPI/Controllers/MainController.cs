using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team5_WebAPI.DAC;
using Team5_WebAPI.Models;

namespace Team5_WebAPI.Controllers
{
    public class MainController : Controller
    {
        List<WorkOrder_VO2> countLog;
        List<WorkOrder_VO2> countmaga;
        List<Item_VO2> countInout;
        List<WorkOrder_VO2> countItem;
        // GET: Main
        public ActionResult Index()
        {
            WorkOrder_DAC dac = new WorkOrder_DAC();
            countLog = dac.CountLog();
            countmaga = dac.CountMaga();
            InOut_DAC dac2 = new InOut_DAC();
            countInout = dac2.InoutCount();
            Item_DAC dac3 = new Item_DAC();
            countItem = dac3.Count_Item();

            int Log = countLog[0].Allcount;
            int maga = countmaga[0].Allcount;
            int item = countItem[0].Allcount;
            ViewBag.Countlog = Log;
            ViewBag.Countmaga = maga;
            ViewBag.CountInout = countInout;
            ViewBag.CountItem = item;



            return View();
        }
    }
}