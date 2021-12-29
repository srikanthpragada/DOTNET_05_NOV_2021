using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreDemo.Pages
{
    public class WelcomeModel : PageModel
    {
        public string Message { get; set; }

        [BindProperty]
        [Required]
        public string Name { get; set; } = "Srikanth";
        public void OnGet()
        {
          
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
                 Message = "Hello " + Name;
        }
    }
}
