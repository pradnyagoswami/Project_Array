using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class smallest_second
    {
        // 8.WAP to find the second smallest element in an array.
        public static void Main(string[] args)
        {
            int[] sm = new int[6];


            for (int i = 0; i < sm.Length; i++)
            {
                Console.WriteLine("Enter Number");
                sm[i] = Convert.ToInt32(Console.ReadLine());
            }
            int small = sm[0];
            int small2 = sm[1];

            for (int i = 0; i < sm.Length; i++)
            {

                if (sm[i] < small)
                {
                    small2 = small;
                    small = sm[i];
                }
                if (sm[i] > small && sm[i] < small2)
                {

                    small2 = sm[i];

                }

            }
            Console.WriteLine("second small number is" + small2);




        }





    }












    
}
