using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace books.Models 
{
    public class CatalogContext : DbContext 
    {
        public CatalogContext() :
            base(DatabaseUtil.ConnectionString)
        {
            //Disable initializer
            Database.SetInitializer<CatalogContext>(null);
        }
        public DbSet<Book> Books { get; set; }
    }
}