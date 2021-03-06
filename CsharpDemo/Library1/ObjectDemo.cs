using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Library1
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} - {this.Age}";
        }

        public override bool Equals(object obj)
        {
            var other = obj as Person;
            return this.Name == other.Name && this.Age == other.Age;
        }

        public override int GetHashCode()
        {
            return this.Age;
        }

        // 0, > 0, < 0
        public int CompareTo(Person other)
        {
            return this.Age - other.Age;
        }
    }

    class ObjectDemo
    {
        static void Main(string[] args)
        {
            var p1 = new Person { Name = "Steve", Age = 30 };
            var p2 = new Person { Name = "Steve", Age = 30 };

            Person[] persons =
                  { new Person{ Name = "Abc", Age = 20},
                    new Person{ Name = "Xyz", Age = 40},
                    new Person{ Name = "Pqr", Age = 16} };

            Array.Sort(persons);

            foreach(var p in persons)
                Console.WriteLine(p);


            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p1 == p2);
            //Console.WriteLine(p1.Equals(p2));

        }
    }
}
