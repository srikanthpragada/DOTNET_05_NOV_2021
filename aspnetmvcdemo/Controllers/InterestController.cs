using aspnetmvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnetmvcdemo.Controllers
{
    public class InterestController : Controller
    {
        // GET: Interest
        public ActionResult Index()
        {
            var model = new Interest();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Interest model)
        {
            if (ModelState.IsValid)
            {
                model.Result = model.Amount * model.Rate / 100;
            }

            return View(model);
        }
    }
}