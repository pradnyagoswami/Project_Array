using System;

namespace Project_Array.Array
{
    internal class Arayy_Avg_Prime
    {
        //WA 
        public static void Main(string[] args)
        {
            int[] arr = new int[6];
            int sum = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine("Enter number");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < arr.Length; i++)
            {

                bool isprime = true;
                for (int j = 2; j < arr[i]; j++)
                {

                    isprime = false;
                    break;
                }
                if (isprime)
                {

                    Console.WriteLine(arr[i]);
                    sum = sum + arr[i];
                    count++;
                }
            }
            double avg = (double)sum / count;
            Console.WriteLine("avg of prime number  = " + avg);



        }
    }
}
