using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class AverageMethod
    {
        public static int Average(int[] array) 
        {
            int count = 0, sum = 0, avg;
            for(int i=0;i<array.Length;i++)
            {

                Console.WriteLine("Enter number");
                array[i] = Convert.ToInt32(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {

                sum = sum + array[i];
                count++;
            
            }
            avg = sum / count;
            return count;
        
        }
        public static double Average(double[] array) 
        {

            int count = 0;
            double avg, sum = 0;
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine("Enter Number");
                array[i]=Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            { 
                sum =(double)sum + array[i];
                count++;
           
            }
            avg = (double)sum / count;
            return avg;
        }
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            Console.WriteLine(Average(array1));
            double[]array2=new double[5];
            Console.WriteLine(Average(array2));


        }

    }
}
