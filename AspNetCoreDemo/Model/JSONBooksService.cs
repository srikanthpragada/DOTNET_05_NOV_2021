using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AspNetCoreDemo.Model
{
    public class JSONBooksService : IBooks 
    {
        // public List<Book> Books { get; set; } = null;
        public String JSONFileName { get; private set; }

      
        public JSONBooksService(IWebHostEnvironment env)
        {
            Console.WriteLine(env.GetType());
            JSONFileName = Path.Combine(env.ContentRootPath,"Data","books.json");
            Console.WriteLine(JSONFileName);
         
        }

        public List<Book> GetBooks()
        {
            using (var sr = new StreamReader(JSONFileName))
            {
                var books = JsonSerializer.Deserialize<List<Book>>(sr.ReadToEnd());
                return books;
            }
        }

        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
