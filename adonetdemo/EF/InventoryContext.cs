using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace adonetdemo.EF
{
    public class InventoryContext : DbContext
    {
        public InventoryContext() :
            base(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True")
        {
            //Disable initializer
            //Database.SetInitializer<InventoryContext>(null);
        }
        public DbSet<Category> Categories { get; set; }
    }
}