using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class FunDemo
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Max(10, 20));
            //int v = 100;
            //Zero(ref v);    // Pass by reference 
            //Console.WriteLine(v);

            //Line(20);
            //Line(15, '*');
            //Line();
            //Line(ch: '*');  // Named parameter
            //Line(ch: '.', len: 5);

            Greet("Hello", "Bill", "Larry", "Mark");
            Greet("Hi", "Joe", "Kevin");

            int x, y;

            TakeValues(out x, out y);
            Console.WriteLine($"x = {x}, y = {y}");
        }

        static void TakeValues(out int a, out int b)
        {
            Console.Write("Enter a number: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            b = Int32.Parse(Console.ReadLine());
        }
        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        static void Zero(ref int n)
        {
            n = 0;
        }

        static void Line(int len = 10, char ch = '-')
        {
            for (int i = 1; i <= len; i++)
                Console.Write(ch);
        }

        static void Greet(string message, params string [] names)
        {
            foreach(string n in names)
                 Console.WriteLine($"{message} {n}");
        }
    }
}
