using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class Rainfall
    {
        public static void Main(String[] args)
        {
            double[] days = new double[7];
            for (int i = 0; i < days.Length; i++)
            {
                days[i] =Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Rainfall in week");
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine($"days[{i}]= {days[i]}");

            }

        }
    }
}