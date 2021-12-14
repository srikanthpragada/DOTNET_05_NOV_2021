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

        [HttpGet]
        public ActionResult Fee()
        {
            ViewBag.Course = "";
            return View();
        }

        [HttpPost]
        public ActionResult Fee(string course)
        {
            if (course == "Java")
                ViewBag.Fee = 10000;
            else
                ViewBag.Fee = 15000;

            ViewBag.Course = course; 
            return View();
        }
    }
}