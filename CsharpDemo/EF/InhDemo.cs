using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class Course
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public int Fee { get; set; }
    }
    [Table("OfflineCourses")]
    class OfflineCourse : Course
    {
        [MaxLength(50)]
        public string Place { get; set; }
    }

    [Table("OnlineCourses")]
    class OnlineCourse : Course
    {
        [MaxLength(50)]
        public string Url { get; set; }

    }

}