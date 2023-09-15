using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class Array_Prime
    {

        public static void Main(string[] args)
        {
            int[] arr = { 1, 4, 2, 7, 8, 9, 12, 15, 19 };
            for(int i=0; i<arr.Length; i++) 
            {
                int count = 0;
                for (int j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    { 
                    
                        count++;
                        break;
                    
                    
                    }
                
                }
                if (count == 0)
                {

                    Console.WriteLine(arr[i]);

                }
            
            
            
            
            
            }

        
        
        
        }

    }
}
