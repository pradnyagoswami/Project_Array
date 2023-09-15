using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class vowel
    {
        public static void Main(string[] args)
        {
            char[] chararry = { 'a', 'b', 'c', 'e', 'z', 'o', 'p', 'u', 'g', 'i' };
            string vowels = "";
            int count = 0;
            for (int i = 0; i < chararry.Length; i++)
            {

                if (chararry[i] == 'a' || chararry[i] == 'e' || chararry[i] == 'i' || chararry[i] == 'o' || chararry[i] == 'u')
                {
                    vowels = vowels + chararry[i];
                    count++;
                
                
                }
            
            }
            Console.WriteLine($"The vowels in the array is { count} this vowels is "+vowels);





        }
    }
}
