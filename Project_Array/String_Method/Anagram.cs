using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.String_Method
{
    internal class Anagram
    {
        //16.Write a C# program to check whether two strings are anagram or not?
        public static string CheckAnagram(string str1, string str2)
        {
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);
            string str3 = new string(ch1);
            string str4 = new string(ch2);

            if (str3 == str4)
            {
                Console.WriteLine("String is Anagram");
            }
            else
            {
                Console.WriteLine("String is not Anagram");
            }
            return $"{str3} {str4}";
        }

        public static void Main(string[] args)
        {
            string str1 = "BTS=The seven normal boys from korea";
            string str2 = "BTS=The seven normal boys from korea";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string str3 = new string(ch1);
            string str4 = new string(ch2);

            if (str3 == str4)
            {
                Console.WriteLine("Strings are Anagram");
            }
            else
            {
                Console.WriteLine("Strings are not Anagram");

            }






        }

    }
}
