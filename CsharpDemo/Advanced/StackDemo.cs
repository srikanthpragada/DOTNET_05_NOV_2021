using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Advanced
{
    class Stack<T> // where T: struct 
    {
        private T[] data = new T[10];
        private int top = 0;
        // Assign default value for data type that replaces T
        private T v = default(T);


        public void Push(T v)
        {
            data[top] = v;
            top++;
        }
    }
    class StackDemo
    {
        static void Main(string[] args)
        {
            var s1 = new Stack<int>();
            s1.Push(10);
      
            var s2 = new Stack<string>();
            s2.Push("Abc");
        }
    }
}
