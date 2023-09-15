using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.String_Method
{
    internal class Longest_word
    {
        // 18.	WAP to find longest word in the given sentence
        public static void Main(string[] args)
        {

            string str = "pradnya rajendra goswami";
            Console.WriteLine(str);
            string[] str1=str.Split(' ');
            string longword = "";
            int max = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                int a = str1[i].Length;
                if (a>max)
                {
                    max = a;
                    longword = str1[i];

                }

            }
            Console.WriteLine(longword);


        }
    }
}
