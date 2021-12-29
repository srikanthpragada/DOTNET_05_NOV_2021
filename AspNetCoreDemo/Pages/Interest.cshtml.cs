using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreDemo.Pages
{
    public class InterestModel : PageModel
    {
        [BindProperty]
        [Range(1000, int.MaxValue, ErrorMessage ="Minimum value is {1}")]
        public int Amount { get; set; }

        [BindProperty]
        [Range(5, 50, ErrorMessage = "Valid rate must be between {1} and {2}")]
        public int Rate { get; set; }

        public int Interest { get; set; }
        public void OnPost()
        {
            if (ModelState.IsValid)
                 Interest = Amount * Rate / 100; 
        }
    }
}
