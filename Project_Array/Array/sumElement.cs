using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class sumElement
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[8];
            Console.WriteLine("Enter the array list");
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];

            }
            Console.WriteLine("The sum of Element Array is = "+sum);
        }





    }




}
