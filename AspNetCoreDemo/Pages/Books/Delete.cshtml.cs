using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetCoreDemo.Model;

namespace AspNetCoreDemo.Pages.Books
{
    public class DeleteModel : PageModel
    {
        private readonly AspNetCoreDemo.Model.CatalogContext _context;

        public DeleteModel(AspNetCoreDemo.Model.CatalogContext context)
        {
            _context = context;
        }

        public string Message { get; set; }
        public void OnGet(int? id)
        {
            if (id == null)
            {
                Message = "Sorry! Book id is missing!";
                return;
            }

            var book = _context.Books.Find(id);

            if (book != null)
            {
                _context.Books.Remove(book);
                 _context.SaveChanges();
                Message = $"Book [{book.Title}] has been deleted!";
            } 
            else
            {
                Message = "Sorry! Book with the given id is not found!";
            }



            
        }

        
    }
}
