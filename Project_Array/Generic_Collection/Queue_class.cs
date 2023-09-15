using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Generic_Collection
{
    internal class Queue_class
    {
        public static void Main(string[] args)
        {

            Queue<int> queue = new Queue<int>();

            //Enqueue
            queue.Enqueue(102);
            queue.Enqueue(100);
            queue.Enqueue(99);
            queue.Enqueue(203);
            queue.Enqueue(201);

            //Dequeue

            queue.Dequeue();//remove first element 

            Console.WriteLine("First Element in the queue "+queue.Peek());

            foreach (int q in queue)
            {
                Console.WriteLine(q);
            }
                
                









        }



    }
}
