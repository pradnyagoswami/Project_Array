using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class SearchElement
    {
        public static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Enter number you wants to be search");
            int a = Convert.ToInt32(Console.ReadLine());
            bool isfound = false;
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == a)
                {
                    isfound = true;
                    index = i;
                    

                }
                
            }
            if (isfound)
            {
                Console.WriteLine($"{a} found at {index} index");

            }
            else 
            {
                Console.WriteLine("Not present");

            }
            

        }
    }
}
