using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Collections
{
    internal class Queue_class
    {
        public static void Main(string[] args)
        {

            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);
            queue.Enqueue(400);

            queue.Dequeue();//remove first element 100

            Console.WriteLine("First element in the queue"+queue.Peek());

            foreach (var Q in queue)
            {

                Console.WriteLine(Q);



            }





        }





    }
}
