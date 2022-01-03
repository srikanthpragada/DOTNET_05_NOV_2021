using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetCoreDemo.Model;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreDemo.Pages.Books
{
    public class SearchModel : PageModel
    {
        private readonly CatalogContext _context;

        [BindProperty]
        [Required]
        public string Title { get; set; }

        public SearchModel(CatalogContext context)
        {
            _context = context;
        }

        public IList<Book> Books { get; set; } = null;

        public void OnGet ()
        {
             
        }

        public void OnPost()
        {
            if(ModelState.IsValid)
                Books = _context.Books.Where( b => b.Title.Contains(Title) ).ToList();
        }
    }
}
