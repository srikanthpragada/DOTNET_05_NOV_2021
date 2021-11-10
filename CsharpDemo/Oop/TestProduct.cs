using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Oop
{
    class Product
    {
        // Fields
        private string name;
        private int price, qoh;

        // Constructor 
        public Product(string n, int p, int q = 0)
        {
            name = n;
            price = p;
            qoh = q;
        }

        // Methods 

        public void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(price);
            Console.WriteLine(qoh); 
        }
      
        public void Purchase(int qty)
        {
            qoh += qty;
        }

        public void Sell(int qty)
        {
            qoh -= qty;
        }

        public int GetQoh()
        {
            return qoh;
        }

        public int GetPrice()
        {
            return price;
        }
    }
    class TestProduct
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("iPhone 13", 120000, 5);  // create an object
            Product p2 = new Product("Dell XPS Laptop", 200000);
            p1.Sell(2);
            p1.Print();

            Console.WriteLine(p1.GetQoh());

        }
    }
}
