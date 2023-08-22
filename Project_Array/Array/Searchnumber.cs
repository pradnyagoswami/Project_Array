using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class Searchnumber
    {
        public static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter number");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter Number to be search");
            int a=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == a)
                {

                    Console.WriteLine($"{a} found at {i} index ");


                }
            
            }


        }





    }
}
