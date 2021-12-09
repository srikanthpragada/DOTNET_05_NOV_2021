using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class ProxyDemo
    {
        static void Main(string[] args)
        {
            var ctx = new HRContext();
            // EF Log to console 
            ctx.Database.Log = Console.WriteLine;

            var emp = ctx.Employees.Find(1);
            Console.WriteLine(emp.GetType().FullName);

        }
    }
}
