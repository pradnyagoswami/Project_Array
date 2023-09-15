using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Generic_Collection
{
    internal class Stack_class
    {
        public static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();

            stack.Push(2022);
            stack.Push(2032);
            stack.Push(2033);
            stack.Push(2036);

            stack.Pop();//remove the top element

            Console.WriteLine("First element = "+stack.Peek());

            foreach (int s in stack)
            {
                Console.WriteLine(s);



            } 



        }


    }
}
