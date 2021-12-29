using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreDemo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreDemo.Pages
{
    public class ListBooksModel : PageModel
    {
        public List<Book> Books { get; set; }

        public ListBooksModel(IBooks books)
        {
            Books = books.GetBooks();
        }
        public void OnGet()
        {
           
        }
    }
}
