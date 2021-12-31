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
    public class ListModel : PageModel
    {
        private readonly CatalogContext _context;

        public ListModel(CatalogContext context)
        {
            _context = context;
        }

        public IList<Book> Books { get;set; }

        public async Task OnGetAsync()
        {
            Books = await _context.Books.ToListAsync();
        }
    }
}
