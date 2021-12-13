using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class ListCourses
    {
        static void Main(string[] args)
        {
            var ctx = new TrainingContext();
            // EF Log to console 
            ctx.Database.Log = Console.WriteLine;

            // List all courses 
            foreach (var c in ctx.Courses)
            {
                Console.WriteLine(c.Name);
                Console.WriteLine(c.GetType().FullName);
            }

            // List all offline courses
            foreach (var c in ctx.OfflineCourses)
            {
                Console.WriteLine(c.Name);
            }

        }
    }
}
