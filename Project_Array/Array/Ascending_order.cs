using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class Ascending_order
    {
        /// declare an array of 5 elements & sort it in asc order int[] arr = { 45, 67, 12, 89, 5 };

        public static void Main(string[] args)
        {

            int[] asc = { 45, 67, 12, 89, 5 };
            for (int i = 0; i < asc.Length; i++)
            {

                for (int j = 0; j < asc.Length; j++)
                {

                    if (asc[i] < asc[j])
                    {

                        int temp;
                        temp = asc[i];
                        asc[i] = asc[j];
                        asc[j]= temp;
                    }
                }
            }
            Console.WriteLine("asc order");
            foreach (var item in asc)
            {
                Console.WriteLine(item);
            }


            int[] dsc = { 45, 67, 12, 89, 5 };
            for (int i = 0; i < dsc.Length; i++)
            {

                for (int j = 0; j < dsc.Length; j++)
                {

                    if (dsc[i] > dsc[j])
                    {

                        int temp;
                        temp = dsc[i];
                        dsc[i] = dsc[j];
                        dsc[j] = temp;
                    }
                }
            }
            Console.WriteLine("dsc order");
            foreach (var item1 in dsc)
            {
                Console.WriteLine(item1);
            }





        }






    }








    }

