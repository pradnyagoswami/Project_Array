using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Collections
{
    internal class Stack_
    {
        public static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(11);
            s.Push(12);
            s.Push(13);
            s.Push(14);

            s.Pop();// remove the top element

            // Peek()-- returns the top element in the stack

            Console.WriteLine("Top element "+s.Peek());

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
                



        }




    }
}
