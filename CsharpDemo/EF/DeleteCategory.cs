using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class DeleteCategory
    {
        static void Main(string[] args)
        {
            var ctx = new InventoryContext();
            // EF Log to console 
            ctx.Database.Log = Console.WriteLine;

            var category = (from cat in ctx.Categories
                      where cat.Code == "ud"
                      select cat).SingleOrDefault();

            if (category == null)
            {
                Console.WriteLine("Sorry! Category Not Found!");
                return; 
            }

            ctx.Categories.Remove(category);

            var count = ctx.SaveChanges();

            Console.WriteLine($"Deleted {count} row(s)");
        }
    }
}
