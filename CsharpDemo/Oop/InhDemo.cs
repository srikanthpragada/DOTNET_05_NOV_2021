using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Oop
{

    class Student
    {
        protected string name, email, college;
        public Student(string name, string email, string college)
        {
            this.name = name;
            this.email = email;
            this.college = college;
        }

        public virtual void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.email);
            Console.WriteLine(this.college);
        }

    }

    class ForeginStudent : Student
    {
        protected string country;
        public ForeginStudent(string name, string email, string college, string country)
            : base(name, email, college)
        {
            this.country = country;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(this.country);
        }
    }
    class InhDemo
    {
        static void Main(string[] args)
        {
            Student s = new ForeginStudent("Abc", "abc@gmail.com", "MIT", "India"); // Upcasting
            s.Print();  // Runtime polymorphism 

            ForeginStudent fs = s as ForeginStudent;

            s = new Student("Xyz", "xyz@gmail.com", "Standford");
            s.Print(); // Runtime polymorphism 

            Console.WriteLine(s is ForeginStudent);
        }
    }
}
