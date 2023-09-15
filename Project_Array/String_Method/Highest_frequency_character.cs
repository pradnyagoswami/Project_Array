using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.String_Method
{
    internal class Highest_frequency_character
    {
        //12.	Write a C# program to find highest frequency character in a string.
        public static void Main(string[] args)
        {
            string str = "my name is pradnya";
            int[] charcount= new int[155];

            for (int i = 0; i < str.Length; i++)
            { 
            
                char ch= str[i];
                charcount[ch]++;
               
            
            }
            int maxcount = 0;
            char maxchar = '\0';

            for (int i = 0; i < 155; i++)
            {

                if (charcount[i] > maxcount)
                {
                    maxcount = charcount[i];
                    maxchar = (char)i;

                }
            
            }
            Console.WriteLine(maxchar);

        }





    }
}
