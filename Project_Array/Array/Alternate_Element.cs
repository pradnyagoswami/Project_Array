using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class Alternate_Element
    {
        public static void Main(string[] args)
        {

            int[] arr = { 2, 3, 7, 9, 6, 4, 5, 2 };

            for(int i=0;i<arr.Length; i++) 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(arr[i]);

                }
            
            }
        
        }




    }
}
