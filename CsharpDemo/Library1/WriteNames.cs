using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Library1
{
    class WriteNames
    {
        static void Main(string[] args)
        {
            var sw = new StreamWriter(@"c:\classroom\nov5\names.txt");

            while(true)
            {
                Console.Write("Enter name [end to stop] :");
                var name = Console.ReadLine();
                if (name == "end")
                    break;

                sw.WriteLine(name);
            }

            sw.Close();
        }
    }
}
