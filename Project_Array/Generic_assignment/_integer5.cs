using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Generic_assignment
{
    internal class _integer5
    {
        public static void Main(string[] args)
        {

            //1.WAP to create an array of 5 integers. Initialize 5 values. Display using foreach loop.
            int[] arr = { 2, 6, 5, 7, 8 };
            List<int> list = new List<int>();
            foreach (int i in arr)
            {
                Console.WriteLine(i);

            }


        }

    }
}
