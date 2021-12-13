using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class TrainingContext : DbContext 
    {
        public TrainingContext() :
           base(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True")
        {

            // Disable initializer
            Database.SetInitializer<TrainingContext>(null);
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<OfflineCourse> OfflineCourses { get; set; }
        public DbSet<OnlineCourse> OnlineCourses { get; set; }
    }
}
