using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.String_Method
{
    internal class sumOFAlterElement
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 5, 9, 8, 7, 5, 6, };

            for (int i = 0; i < arr.Length - 2; i++)
            {
                Console.WriteLine(arr[i] + arr[i+2]);

            }
        
        
        
        
        
        }
    }
}
