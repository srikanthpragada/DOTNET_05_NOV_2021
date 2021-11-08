using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class HigherPrices
    {
        static void Main(string[] args)
        {
            int[] prices = { 500, 340, 560, 234, 55, 666, 333, 373, 120, 482 };
            float average, sum = 0;

            for (int i = 0; i < prices.Length; i++)
                sum += prices[i];

            average = sum / prices.Length;

            Console.WriteLine($"Average = {average:####.00}");

            foreach (int n in prices)
            {
                if (n > average)
                    Console.WriteLine(n);
            }

        }
    }
}
