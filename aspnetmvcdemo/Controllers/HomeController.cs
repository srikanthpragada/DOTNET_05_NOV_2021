using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnetmvcdemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Wish()
        {
            var hour = DateTime.Now.Hour;

            if (hour < 12)
                ViewBag.Wish = "Good Morning";
            else
                if (hour < 17)
                ViewBag.Wish = "Good Afternoon";
            else
                ViewBag.Wish = "Good Eveing";

            return View();
        }
    }
}