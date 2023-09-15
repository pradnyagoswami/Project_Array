using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class MaxChar
    {

        public static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'e' };

            char maxChar = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] > maxChar)
                { 
                
                    maxChar= arr[i];
                
                
                }
            
            }
            Console.WriteLine("The maximum character is "+maxChar);


        }
    }
}
