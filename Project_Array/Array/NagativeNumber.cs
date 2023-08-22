using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    public class NagativeNumber
    {

       public  static void Main(string[] args)
        {
            int[] nagative = new int[5];
            int count = 0;
            for (int i = 0; i < nagative.Length; i++)
            {

                Console.WriteLine("Enter a number");
                nagative[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < nagative.Length; i++)
            {

                Console.WriteLine(nagative[i]+"nagative number");
                count++;

            }
            Console.WriteLine($"Total count of nagative number is = "+count);





        
        
        
        
        }


    }
}
