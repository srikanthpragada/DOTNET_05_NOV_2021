using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class UpdateCategory
    {
        static void Main(string[] args)
        {
            var ctx = new InventoryContext();
            // EF Log to console 
            ctx.Database.Log = Console.WriteLine;

            var category = (from cat in ctx.Categories
                      where cat.Code == "lt"
                      select cat).SingleOrDefault();
            Console.WriteLine("Before Change : " + ctx.Entry(category).State);


            if (category == null)
            {
                Console.WriteLine("Sorry! Category Not Found!");
                return; 
            }
            category.Description = "Laptops";
            Console.WriteLine("After Change : " + ctx.Entry(category).State);
            var count = ctx.SaveChanges();

            Console.WriteLine($"Updated {count} row(s)");
            ctx.Dispose();

        }
    }
}
