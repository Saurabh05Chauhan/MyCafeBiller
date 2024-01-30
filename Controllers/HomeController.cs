using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCafeBiller.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<string> food = new List<string>();
            food.Add("Pizza");
            ViewBag.foodItem=food;
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