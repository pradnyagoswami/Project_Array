using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Generic_Collection
{
    internal class List_class
    {
        public static void Main(string[] args)
        {

            List<int> list = new List<int>();
            //Add
            list.Add(100);
            list.Add(20);
            list.Add(35);
            list.Add(46);
            list.Add(500);

            ////Insert
            list.Insert(2, 500);

            //sort
            list.Sort();

            //RemoveAt
            list.RemoveAt(2);
            list.RemoveAt(1);

            //Reverse
            list.Reverse();

            //count
            Console.WriteLine("count of total element = "+list.Count);

            //capacity
            Console.WriteLine("Capacity of element = "+list.Capacity);

            foreach (int i in list)
            {

                Console.WriteLine(i);

            }










        }


    }
}
