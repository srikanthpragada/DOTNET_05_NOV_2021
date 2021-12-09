using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class ListEmployeesLazyLoad
    {
        static void Main(string[] args)
        {
            var ctx = new HRContext();
            // EF Log to console 
            ctx.Database.Log = Console.WriteLine;

            // List all categories 
            foreach (var emp in ctx.Employees)
                Console.WriteLine($"{emp.Name} - {emp.Department.Name}");
        }
    }
}
