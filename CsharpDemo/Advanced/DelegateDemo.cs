using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Advanced
{
    class DelegateDemo
    {
        public delegate void PrintDelegate(string message);
        static void Main(string[] args)
        {
            var d = new PrintDelegate(Print);
            d("Hello");
            d.Invoke("Hi");

            // Method group conversion
            PrintDelegate d2 = Print;
            d2("Good Morning!");

            // Anonymous method 
            PrintDelegate d3 = delegate (String msg)
            {
                Console.WriteLine(msg);
            };

            d3("How are you?");

            // Lambda Expression 
            PrintDelegate d4 = msg => Console.WriteLine(msg);
            d4("Good Bye!");

         }

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
