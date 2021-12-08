using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class CacheCategory
    {
        static void Main(string[] args)
        {
            var ctx = new InventoryContext();
            // EF Log to console 
            ctx.Database.Log = Console.WriteLine;

            var category = ctx.Categories.Find("ud");


            if (category == null)
            {
                Console.WriteLine("Sorry! Category Not Found!");
                return;
            }
            Console.WriteLine(category.GetHashCode());

            var category2 = ctx.Categories.Find("ud");

            Console.WriteLine(category2.GetHashCode());


        }
    }
}
