using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Advanced
{
    class AnonymousDemo
    {
        static void Main(string[] args)
        {
            // Anonymous Type with Day and Month properties 
            var d = new { Day = 1, Month = 1 };
            Console.WriteLine(d.Day);
        }
    }
}
