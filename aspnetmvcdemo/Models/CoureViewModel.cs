using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspnetmvcdemo.Models
{
    public class CoureViewModel
    {
        public string[] Courses
        {
            get
            {
                return new string[] { "Microsoft.NET", "Java", "Python" };
            }
        }

        public string Trainer
        {
            get
            {
                return "Srikanth Pragada";
            }
        }

    }
}