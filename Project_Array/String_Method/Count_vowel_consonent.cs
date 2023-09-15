using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.String_Method
{
    internal class Count_vowel_consonent
    {

        //9.	Write a C# program to count total number of vowels and consonants in a string.
        public static void Main(string[] args)
        {
            string str = "India is my country";
            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char ch= str[i];
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    count1++;

                }
                else
                {
                    count2++;

                }

            }
            Console.WriteLine("The number of vowel in string =" + count1);
            Console.WriteLine("The number of consonent in string =" + count2);
        }

        }
}
