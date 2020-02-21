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

                keys.Add(group.Key); //key = 제품명 
                List<int> qtys = new List<int>();
                List<int> Shipqtys = new List<int>();
                foreach (var product in group)
                {
                    if (k == 0)
                        sb.Append(product.MM + "월,");
                    qtys.Add(product.Qty);
                    Shipqtys.Add(product.Sales_shipQty);

                }
                if (k == 0)
                    data1 = "[" + string.Join(",", qtys.ToArray()) + "]";
                data2 = "[" + string.Join(",", Shipqtys.ToArray()) + "]";



                k++;
                qtys.Clear();
            }
            string labels = sb.ToString().TrimEnd(',');
            string label1 = keys[0];

            ViewBag.Labels = labels;
            ViewBag.Label1 = label1;
            ViewBag.data1 = data1;
            ViewBag.data2 = data2;
            ViewBag.list = list;

            //--------------------------------------------------------------------------
            Sales_DAC chart2 = new Sales_DAC();
            List<Sales_VO> list2 = chart2.Search_PriceOrder(); ;



            var listStat2 = from stat in list2
                            orderby stat.Sales_StartDate
                            group stat by stat.COM_Code;

            List<string> keys2 = new List<string>();
            StringBuilder sb2 = new StringBuilder();
            string SalesData2 = string.Empty;


            int j= 0;
            foreach (var group in listStat2)
            {

                keys2.Add(group.Key); //key = 제품명 
                List<string> qtys2 = new List<string>();

                foreach (var product in group)
                {
                    if (j == 0)
                        sb2.Append(product.Sales_StartDate + "월,");
                    qtys2.Add(product.Sales_Price_Now);


                }
                if (j == 0)
                    SalesData2 = "[" + string.Join(",", qtys2.ToArray()) + "]";

               j++;
                qtys2.Clear();
            }
            string Month = sb2.ToString().TrimEnd(',');
            string Model = keys2[0];



            ViewBag.model = Model;
            ViewBag.month = Month;
            ViewBag.salesdata = SalesData2;
            ViewBag.saleslist = list2;

            return View();
        }

       
    }
   
}
