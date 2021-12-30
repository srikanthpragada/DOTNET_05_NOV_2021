using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcore.Pages.Ajax
{
    public class ContactsModel : PageModel
    {
        public JsonResult OnGet()
        {
            var contacts = new[] { new { Name = "Larry Ellison", Email = "larry@oracle.com" },
                                   new { Name = "Sergy Brin", Email = "brin@google.com" },
                                   new { Name = "Bill Gates", Email = "bill@microsoft.com"}
            };
            return new JsonResult(contacts);
        }
    }
}
