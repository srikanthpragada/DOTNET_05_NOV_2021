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

        private static int taxrate = 8;

        // Constructor 
        public Product(string name, int price, int qoh = 0)
        {
            this.name = name;
            this.price = price;
            this.qoh = qoh;
        }

        // Methods 

        public void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.price);
            Console.WriteLine(this.qoh);
        }

        public void Purchase(int qty)
        {
            this.qoh += qty;
        }

        public void Sell(int qty)
        {
            this.qoh -= qty;
        }

        public int GetQoh()
        {
            return this.qoh;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public int GetNetPrice()
        {
            return this.price + this.price * Product.taxrate / 100;
        }
        // Static method 
        public static int GetTaxRate()
        {
            return Product.taxrate;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length > 0)
                    this.name = value;
            }
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

            Console.WriteLine(p1.GetNetPrice());
        }
    }
}
