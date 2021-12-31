using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Controllers
{
    public class AboutController : Controller
    {
        public string Message { get; set; }

        // Action - Index
        public IActionResult Index()
        {
            var hours = DateTime.Now.Hour;
            if (hours < 12)
                Message = "Good Morning";
            else
                Message = "Good Evening";


            return View("Index", Message);  // Viewname, Model
        }

        public IActionResult Authors()
        {
            return View();
        }
    }
}
