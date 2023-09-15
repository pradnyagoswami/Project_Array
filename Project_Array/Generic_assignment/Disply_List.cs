using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Generic_assignment
{
    internal class Disply_List
    {

        public static void Main(string[] args)
        {
            //Disply list in various ways

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            //using for loop
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);

            //}

            //using foreach loop
           
            foreach (int i in list) 
            {
                Console.WriteLine(i);

            }







        }

    

    }
}
