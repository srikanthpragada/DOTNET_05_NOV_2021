using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreDemo.Pages
{
    public class SaveCityModel : PageModel
    {
        [BindProperty]
        [Required]
        public string City { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page(); 
            }

            // Store city as cookie
            var options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(10)
                
            };

            Response.Cookies.Append("city",City, options);
            return RedirectToPage("Movies");
       }
    }
}
