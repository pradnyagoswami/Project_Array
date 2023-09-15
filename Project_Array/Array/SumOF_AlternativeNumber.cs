using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class SumOF_AlternativeNumber
    {
        public static void Main(string[] args)
        {
            //WA to show sum of alternative number from array

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i += 2)
            {

                sum = sum + i;
            
            }
            Console.WriteLine("Sum of alternative number is = "+sum);




        }



    }
}
