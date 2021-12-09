using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class HRContext : DbContext
    {
        public HRContext() :
            base(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True;MultipleActiveResultSets=True")
        {
            // Disable initializer
            Database.SetInitializer<HRContext>(null);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
