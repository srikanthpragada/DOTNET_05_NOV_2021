using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AspNetCoreDemo.Model;

namespace AspNetCoreDemo.Pages.Books
{

    public class AddModel : PageModel
    {
        private readonly AspNetCoreDemo.Model.CatalogContext _context;

        public AddModel(CatalogContext context)
        {
            _context = context;
        }

       
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Books.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./List");
        }
    }
}
