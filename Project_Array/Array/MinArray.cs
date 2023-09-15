using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class MinArray
    {
        public static void Main(string[] args)
        {
            //By declare array
            //int[] arr = { 1,2, 6, 8, 7, 9, 10, 6, };
            //int a = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < a)
            //    { 
            //        a= arr[i];

            //    }

            //}
            //Console.WriteLine(a);

            /* taking input from user*/
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enetr {arr.Length} numbers");
                arr[i]=Convert.ToInt32(Console.ReadLine());

            }
            int a = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<a)
                {
                    a = arr[i];

                }
            }
            Console.WriteLine("minimum number is "+a);

        }
    }
}
