using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STLibrary;

namespace DotNetCoreDemo
{
    class UseCounter
    {
        static void Main(string[] args)
        {
            var c = new Counter();
            c.Increment();
            c.Increment();
            Console.WriteLine(c.Value);
        }
    }
}
