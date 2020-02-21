using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Team5_WebAPI.DAC;
using Team5_WebAPI.Models;

namespace Team5_WebAPI.Controllers
{
    public class InoutController : Controller
    {       
        // GET: Inout
        List<InOut_VO> list;
        public ActionResult Index()
        {
            int i = 1;
            InOut_DAC dac = new InOut_DAC();
            list = dac.SearchInItem();
         

            var listStat = from stat in list
                           orderby stat.InOut_Date
                           where stat.InOut_Gubun =="입고"
                           group stat by stat.InOut_Gubun;

            var listStat2 = from stat in list
                           orderby stat.InOut_Date
                           where stat.InOut_Gubun == "출고"
                           group stat by stat.InOut_Gubun;


            List<string> keys = new List<string>();
            StringBuilder sb = new StringBuilder();
            List<string> keys2 = new List<string>();
            StringBuilder sb2 = new StringBuilder();
            string data1 = string.Empty;
            string data2 = string.Empty;
            

            int k = 0;
            foreach (var group in listStat)
            {

                keys.Add(group.Key); //key = 제품명 
                List<int> qtys = new List<int>();
                foreach (var product in group)
                {
                    if (k == 0)
                        sb.Append(product.InOut_Date + "월,");
                    qtys.Add(product.Total);
                }
            
                if (k == 0)
                    data1 = "[" + string.Join(",", qtys.ToArray()) + "]";
              

                k++;
                qtys.Clear();
            }
            string labels = sb.ToString().TrimEnd(',');
            string label1 = keys[0];





            int M = 0;
            foreach (var group2 in listStat2)
            {

                keys2.Add(group2.Key); //key = 제품명 
                List<int> qtys2 = new List<int>();
                foreach (var product2 in group2)
                {
                    if (M == 0)
                        sb2.Append(product2.InOut_Date + "월,");
                    qtys2.Add(product2.Total);
                }

                if (M == 0)
                    data2 = "[" + string.Join(",", qtys2.ToArray()) + "]";

                M++;
                qtys2.Clear();
            }
            string labels2 = sb2.ToString().TrimEnd(',');
            string label2 = keys2[0];

            ViewBag.Ints = i;
            ViewBag.Intt = i;
            ViewBag.Labels = labels;
            ViewBag.Label1 = label1;
            ViewBag.data = data1;

            ViewBag.Labels1 = labels2;
            ViewBag.Label2 = label2;
            ViewBag.data2 = data2;

            return View(list);
        }
    }
}