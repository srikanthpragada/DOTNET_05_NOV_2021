using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Library1
{
    class TotalMarks
    {
        static void Main(string[] args)
        {
            string input = "89,44,55,,64;78";

            var marks = input.Split(',', ';');

            int total = 0;
            foreach(var m in marks)
            {
                try
                {
                    total += Int32.Parse(m);
                }
                catch(Exception ex)
                {
                    // ignore error 
                }
            }

            Console.WriteLine(total);
        }
    }
}
