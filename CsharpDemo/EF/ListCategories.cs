using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class ListCategories
    {
        static void Main(string[] args)
        {
            var ctx = new InventoryContext();
            // EF Log to console 
            ctx.Database.Log = Console.WriteLine;

            // List all categories 
            foreach (var cat in ctx.Categories)
                Console.WriteLine($"{cat.Code}  - {cat.Description}");

            // List categories where code starts with m
            foreach (var cat in ctx.Categories.Where(c => c.Code.StartsWith("m")))
                Console.WriteLine($"{cat.Code}  - {cat.Description}");

            var selcats = from c in ctx.Categories
                          where c.Code.StartsWith("u")
                          select c;

            foreach (var cat in selcats)
                Console.WriteLine($"{cat.Code}  - {cat.Description}");

        }
    }
}
