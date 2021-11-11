using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Oop
{
    class Person
    {
        // Auto implemented properties 
        public string Name { get; set; }
        public string Email { get; set; }

    }
    class TestPerson
    {
        static void Main(string[] args)
        {
            var p1 = new Person { Name = "Scott", Email = "scott@microsoft.com" };

        }
    }
}
