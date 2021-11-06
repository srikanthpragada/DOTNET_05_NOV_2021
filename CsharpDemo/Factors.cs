using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Factors
    {
        static void Main()
        {
            int num, i;

            Console.Write("Enter a number :");
            num = Int32.Parse(Console.ReadLine()); // Convert string to int

            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    Console.WriteLine(i);
            }


        }
    }
}
