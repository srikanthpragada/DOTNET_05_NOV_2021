using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Advanced
{
    class FindAllDemo
    {
        static bool LargeName(string name)
        {
            return name.Length > 5;
        }
        static void Main(string[] args)
        {
            string[] names = { "Bill Gates", "Larry Page", "Larry Ellison", "Dell", "James" };

            foreach(var v in Array.FindAll(names, LargeName))
                Console.WriteLine(v);

            // Anonymous method 
            var selectednames = Array.FindAll(names, delegate (string msg)
            {
                return msg.Length < 5;
            });

            foreach (var v in selectednames)
                Console.WriteLine(v);


            // Lambda 
            selectednames = Array.FindAll(names, n => n.Length == 5);

            foreach (var v in selectednames)
                Console.WriteLine(v);
        }
    }
}
