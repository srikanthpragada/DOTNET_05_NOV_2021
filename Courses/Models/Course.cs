using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class Course
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Title { get; set; }

        public int Duration { get; set; }

        public int Fee { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
