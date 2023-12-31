﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.String_Method
{
    internal class String_Array
    {

        public static void Main(string[] args)
        {
            //1.	WAP to split string into 2 tokens where string is “HELLO$WORLD”
            string st = " HELLO$WORLD ";
            string[] sarray = st.Split('$');
            Console.WriteLine(sarray[0]);
            Console.WriteLine(sarray[1]);


            //2.	Write a C# program to find first occurrence of a character in a given string.
            Console.WriteLine("index = " + st.IndexOf('L'));


            //3.	Write a C# program to count occurrences of a character in given string.
            Console.WriteLine(st.IndexOf('L') + "=1st Occurance of L");

            char[] ch = st.ToCharArray();
            int cnt = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'L')
                {
                    cnt++;
                }
            }
            Console.WriteLine($"Occurance of L={cnt}");


            // 4.Write a C# program to trim leading white space characters in a string.
            string str = string.Concat(st.Trim());
            Console.WriteLine(str);


            //5.	Write a C# program to count total number of words in a string. 

            int countwords = 0;
            for (int i = 0; i < str.Length; i++)
            {
                countwords++;
            }
            Console.WriteLine($"Total Words in String={countwords}");


            //6.Write a C# program to remove all occurrences of a character from string.
            string str3 = "World2 ";
            Console.WriteLine(str3.TrimEnd());


            //7.Write a C# program to trim trailing white space characters in a string.
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'L')
                {
                    ch[i] = '\0';
                }
            }

            foreach (char s in ch)
            {

                Console.WriteLine(s);


            }
        }
    }
}
