using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.String_Method
{
    internal class stringArrayDisply
    {

        public static void Main(string[] args)
        {



            String[] arr = new String[3];
            // arr[0] = "pune";
            // arr[1] = "mumbai";
            // arr[2] = "nashik"En;

            //from user
            Console.WriteLine($"Enter {arr.Length} Names");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]=Console.ReadLine();

            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }




        }
    }
}
