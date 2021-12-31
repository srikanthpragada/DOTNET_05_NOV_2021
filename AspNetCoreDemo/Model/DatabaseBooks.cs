using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AspNetCoreDemo.Model
{
    public class DatabaseBooks : IBooks
    {

        public CatalogContext Context { get; set; }


        public DatabaseBooks(CatalogContext ctx)
        {

            Context = ctx;
        }

        public List<Book> GetBooks()
        {
            return Context.Books.ToList<Book>();
        }

        public void AddBook(Book book)
        {
            Context.Books.Add(book);
            Context.SaveChanges();
        }
    }
}
