using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc5_1.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string Id, string name)
        {
            return "Id = "+ Id + " AND Name :" + name;
        }

        public ActionResult GetDetails()
        {
            
            ViewBag.Countries = new List<string>()
            
            {
                "India",
                "US",
                "UK",
                "Canada"

            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}