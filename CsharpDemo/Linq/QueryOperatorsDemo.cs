using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Linq
{

    class QueryOperatorsDemo
    {
        static bool CostlyBook(Book book)
        {
            return book.Price > 500;
        }

        static void Main(string[] args)
        {
            var books = Book.GetBooks();

            /*
            // List books with price > 500 
            var costly_books1 = books.Where(CostlyBook);
            var costly_books2 = books.Where(b => b.Price > 500);

            foreach(var b in costly_books2)
                Console.WriteLine(b);
       
            */

            /*
            // List title and discounted price for books with price > 500 
            var dis_books = books.Where(b => b.Price > 500)                        // selection - filtering
                                 .Select(b => new { Title = b.Title, 
                                                    NetPrice = b.Price * 0.80 });  // Projection

            foreach (var b in dis_books)
                Console.WriteLine($"{b.Title.PadRight(30)} - {b.NetPrice}");
             
            */

            /*
           
            // List 3rd and 4th highested priced books 
            var sortedbooks = books.OrderByDescending(b => b.Price).Skip(2).Take(2);
            foreach(var b in sortedbooks)
                Console.WriteLine(b);
            */


            /*
            // Highest price 
            var maxprice = books.Max(b => b.Price);
            // List first book with highest price 
            var book = books.Where(b => b.Price == maxprice).First();
            Console.WriteLine(book);
            */
                
            
            Console.WriteLine( books.Where(b=> b.Title.Contains("4.0"))
                                    .Sum(b => b.Price));
             
        }
    }
}
