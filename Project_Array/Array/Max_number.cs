using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class Max_number
    {
        public static void Main(string[] args)
        {

            int[] max = new int[6];
            for (int i = 0; i < max.Length; i++)
            {

                Console.WriteLine("Enter a number");
                max[i] = Convert.ToInt32(Console.ReadLine());
            }
            int a = max[0];
            for (int i = 0; i < max.Length; i++)
            {

                if (max[i] > a)
                {

                    a = max[i];
                }

            }
            Console.WriteLine("max number is = "+a);
            int b = max[0];
            for (int i = 0; i < max.Length; i++)
            {

                if (max[i] < b)
                {

                    b = max[i];
                }
            }
            Console.WriteLine("minimum number is = "+b);


        }



    }
}
