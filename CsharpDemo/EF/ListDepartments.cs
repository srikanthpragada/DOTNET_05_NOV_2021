using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class ListDepartments
    {
        static void Main(string[] args)
        {
            var ctx = new HRContext();
            // EF Log to console 
            // ctx.Database.Log = Console.WriteLine;

            // List all Departments with Employees 
            foreach (var dept in ctx.Departments)
            {
                Console.WriteLine($"Department : {dept.Name}");
                foreach(var emp in dept.Employees)
                {
                    Console.WriteLine(emp.Name);
                }
            }
        }
    }
}
