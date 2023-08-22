using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class EvenNumberOnly1
    {

        public static void Main(String[] args)
        {
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter numbers");
                num[i]=Convert.ToInt32(Console.ReadLine()); 
            
            }
            for (int i = 0; i < 10; i++)
            {
                if (num[i]%2==0)
                {
                    Console.WriteLine($"Even number"+num[i]);
                }

                

            }
        
        
        }


    }
}
