using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreDemo.Pages
{
    public class WishModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet([FromQuery] string name = "Guest")
        {
            var ct = DateTime.Now.Hour;
            if (ct < 12)
                Message = "Good Morning!!";
            else
                if (ct < 17)
                   Message = "Good Afternoon!!";
                else
                   Message = "Good Evening!!";

            Message = name + ", " + Message;
        }
    }
}
