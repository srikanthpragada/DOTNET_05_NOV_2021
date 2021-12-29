using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDemo.Model
{
    public interface IBooks
    {
        List<Book> GetBooks();
        void AddBook(Book book);
    }
}
