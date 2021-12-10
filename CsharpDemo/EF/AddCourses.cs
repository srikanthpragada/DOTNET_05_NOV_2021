using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class AddCourses
    {
        static void Main(string[] args)
        {
            TrainingContext ctx = new TrainingContext();

            var c1 = new OfflineCourse
            {
                Name = "Java",
                Fee = 5500,
                Place = "Srikanth Technologies, Vizag"
            };

            var c2 = new OnlineCourse
            {
                Name = "Angular",
                Fee = 4000,
                Url = "https://global.gotomeeting.com/join/698399013"
            };

            ctx.Courses.Add(c1);
            ctx.Courses.Add(c2);
            ctx.SaveChanges();
        }
    }
}
