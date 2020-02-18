using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team5_WebAPI.DAC;
using Team5_WebAPI.Models;

namespace Team5_WebAPI.Controllers
{
    public class WorkOrderController : Controller
    {
        List<WorkOrder_VO> list;
        // GET: WorkOrder
        public ActionResult Index()
        {
            WorkOrder_DAC dac = new WorkOrder_DAC();
            list = dac.ProductCharts();

            return View(list);
        }
    }
}