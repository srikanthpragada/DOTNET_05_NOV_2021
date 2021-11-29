using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Advanced
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    static class ExtensionMethodsDemo
    {
        public static void Print(this Point p)
        {
            Console.WriteLine($"{p.X}, {p.Y}");
        }
    }
    class ExtensionMethods
    {
        static void Main(string[] args)
        {
            var p1 = new Point { X = 10, Y = 20 };
            p1.Print();   // ExtensionMethodsDemo.Print(p1)
        }
    }
}
