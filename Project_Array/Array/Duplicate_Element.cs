using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class Duplicate_Element
    {
        //6.	WAP to find and count total number of duplicate elements in an array.

        public static void Main(string[] args)
        {
            int count = 0;
            int[] arr = { 1, 2, 3, 5, 9, 8, 5, 6, 1, 2, 3, 4, };

            Console.WriteLine("Duplicate number in array");
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i+1; j < arr.Length-1; j++)
                {
                    if (arr[i] == arr[j])
                    {

                        count++;
                        Console.WriteLine(arr[i]);

                    }
                
                }
            }
            Console.WriteLine($"Duplicate number count is "+count);

        }
        


    }
}
