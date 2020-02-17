using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Team5_WebAPI.DAC;
using Team5_WebAPI.Models;

namespace Team5_WebAPI.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
      
            Chart_DAC chart = new Chart_DAC();
            List<Chart_VO> list = chart.GetChartData();
         


            var listStat = from stat in list
                           orderby stat.MM
                           group stat by stat.COM_Code;

            List<string> keys = new List<string>();
            StringBuilder sb = new StringBuilder();
            string data1 = string.Empty;
            string data2 = string.Empty;
            string data3 = string.Empty;
            
            int k = 0;
            foreach (var group in listStat)
            {
                
                keys.Add(group.Key); //key = 제품명 //key = 제품명
                List<int> qtys = new List<int>();
                foreach (var product in group)
                {
                    if (k == 0)
                        sb.Append(product.MM + "월,");
                    qtys.Add(product.Qty);
                }
                if (k == 0)
                    data1 = "[" + string.Join(",", qtys.ToArray()) + "]";
                else if (k == 1)
                    data2 = "[" + string.Join(",", qtys.ToArray()) + "]";
                else if (k == 2)
                    data3 = "[" + string.Join(",", qtys.ToArray()) + "]";

                k++;
                qtys.Clear();
            }
            string labels = sb.ToString().TrimEnd(',');
            string label1 = keys[0];
       


            ViewBag.Labels = labels;
            ViewBag.Label1 = label1;
            ViewBag.data1 = data1;
       
            return View();
        }
       
    }
}