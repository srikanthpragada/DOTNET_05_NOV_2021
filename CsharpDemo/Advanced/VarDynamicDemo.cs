using CsharpDemo.Oop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Advanced
{
    class VarDynamicDemo
    {
        static Product GetProduct()
        {
            return new Product("Abc", 1000);
        }
        static void Main(string[] args)
        {
            var n = 10;
            var a1 = new Account(1,"Abc");

            // n = "abc";

            dynamic d;

            if (n == 10)
                d = GetProduct();
            else
                d = new Account(1, "ABC");

            d.Print();


        }
    }
}
