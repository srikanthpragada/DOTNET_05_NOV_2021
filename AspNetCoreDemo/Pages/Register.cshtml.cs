using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCoreDemo.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [BindProperty]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Invalid Password!")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [BindProperty]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Invalid Password!")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match!")]
        public string ConfirmPassword { get; set; }

        [BindProperty]
        public string Occupation { get; set; } = "S";

        public List<SelectListItem> Occupations { get; } =
             new List<SelectListItem>
        {
                   new SelectListItem { Value = "S", Text = "Student"},
                   new SelectListItem { Value = "E", Text = "Employee"},
                   new SelectListItem { Value = "B", Text = "Business"},

        };


        public string Message { get; set; }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Message = "Succesfully Registered!";
                Console.WriteLine($"{Email}, {Password}, {Occupation}");
            }
            else
                Message = "Sorry! Validation failed!";
        }
    }
}
