using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Collections
{
    internal class arrayList
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 110, 104, 109, 108, 107, 105 };
            ArrayList list = new ArrayList();
            list.Add(101);//0
            list.Add(103);//1
            list.Add(102);//2
            list.Add(106);//3

            //list.Insert(2, 550.00);
            list.AddRange(arr);

            list.Remove(2);//Revove the elements based on Index
           // list.RemoveRange(3,2);//Remove multiple elements at once
           // list.Clear();//Remove all the elements


            list.Sort();
            list.Reverse();
            Console.WriteLine("count of total element"+list.Count);
            Console.WriteLine("capacity = "+list.Capacity);

            foreach (int i in list)
            {
                Console.WriteLine(i);




            }







        }




    }
}
