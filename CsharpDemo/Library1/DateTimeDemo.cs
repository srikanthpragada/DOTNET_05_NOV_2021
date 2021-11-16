using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Library1
{
    class DateTimeDemo
    {
        static void Main(string[] args)
        {
            var d1 = DateTime.Now;
            var d2 = new DateTime(2021, 1, 1);
            var d3 = DateTime.Parse("16-11-2021");  // dd-mm-yyyy
        

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            var ts = d1.Subtract(d2);

            Console.WriteLine(ts.Days);
        }
    }
}
