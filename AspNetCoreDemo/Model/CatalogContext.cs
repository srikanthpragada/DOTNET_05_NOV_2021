using AspNetCoreDemo.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AspNetCoreDemo.Model
{
    public class CatalogContext :  DbContext
    {
        public DbSet<Book> Books { get; set; }
        public string ConnectionString { get; }
        public CatalogContext(Microsoft.Extensions.Configuration.IConfiguration Configuration)
        {
            ConnectionString = Configuration.GetConnectionString("SQLConnection");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(ConnectionString);
        }
        
 
    }
}
