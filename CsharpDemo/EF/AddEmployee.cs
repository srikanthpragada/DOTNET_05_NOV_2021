using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class AddEmployee
    {
        static void Main(string[] args)
        {
            var ctx = new HRContext();
            // EF Log to console 
            ctx.Database.Log = Console.WriteLine;

            // Get Department 
            var dept = ctx.Departments.Find(1);

            // Create employee 
            var emp = new Employee {Name = "Jack", Department = dept, Salary = 800000 };
            ctx.Employees.Add(emp);

            var count = ctx.SaveChanges();
            Console.WriteLine($"Added {count} row(s)");
        }
    }
}
