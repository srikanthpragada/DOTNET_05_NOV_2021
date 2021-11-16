using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Library1
{
    class ReadNames
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(@"c:\classroom\nov5\names.txt");

            while(true)
            {
                var line = sr.ReadLine();
                if (line == null)  // EOF 
                    break;

                Console.WriteLine(line);
            }

            sr.Close();
        }
    }
}
