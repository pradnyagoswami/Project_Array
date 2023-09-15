using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class Array_Odd_position
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine( "Enter the no :" );
                arr[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            
        for(int i=0;i<arr.Length ; i++) 
        {
                if (i % 2 != 0)
                {
                    Console.WriteLine("odd no :"+arr[i]);
                }
             
         }
            
        
        
        
        
        }




    }
}
