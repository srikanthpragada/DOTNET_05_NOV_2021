using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Library1
{
    class StringVertical
    {
        static void Main(string[] args)
        {
            string st;

            Console.Write("Enter a string :");
            st = Console.ReadLine();

            foreach (var c in st)
            {
                Console.WriteLine(c);
            }

            for (int i = st.Length - 1; i >= 0; i--)
                Console.WriteLine(st[i]);
        }
    }
}
