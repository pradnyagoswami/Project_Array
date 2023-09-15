using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class Array_sumOfEven
    {
        public static void Main(string[] args)
        {

            int[] a = { 2, 6, 8, 6, 7, 1, 9, 8, 5, 2 };
            int sum = 0;
            
            for (int i = 0; i < a.Length; i++)
            {   
                    if (a[i] % 2 == 0)
                    {
                         sum = sum + a[i];
                   
                    }
    
             }
            Console.WriteLine(sum);
        }
        
        
        
        
        



    }
}
