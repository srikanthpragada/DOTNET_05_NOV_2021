using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class AddCategory
    {
        static void Main(string[] args)
        {
            var ctx = new InventoryContext();
            // EF Log to console 
            ctx.Database.Log = Console.WriteLine;

            var cat = new Category { Code = "lt", Description = "Laptop" };
            ctx.Categories.Add(cat);
            Console.WriteLine("After added : " + ctx.Entry(cat).State);

            var count = ctx.SaveChanges();
            Console.WriteLine($"Added {count} categories");
        }
    }
}
