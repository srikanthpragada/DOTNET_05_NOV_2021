using aspnetmvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnetmvcdemo.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            string  [] courses = { "Microsoft.NET","Java", "Python"};
            ViewBag.Courses = courses;
            ViewBag.Trainer = "Srikanth Pragada";
            return View();
        }

        public ActionResult List()
        {
            var model = new CoureViewModel();
           
            return View(model);
        }
    }
}