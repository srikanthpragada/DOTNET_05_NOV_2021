using AspNetCoreDemo.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace AspNetCoreDemo.Model
{
    public class CatalogContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public string ConnectionString { get; }
        public CatalogContext(IConfiguration Configuration)
        {
            ConnectionString = Configuration.GetConnectionString("SQLConnection");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.LogTo(Console.WriteLine, LogLevel.Information);
            options.UseSqlServer(ConnectionString);
        }


    }
}
