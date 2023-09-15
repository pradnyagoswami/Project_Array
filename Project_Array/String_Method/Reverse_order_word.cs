using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.String_Method
{
    internal class Reverse_order_word
    {
        //11.	Write a C# program to reverse order of words in a given string.
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str=Convert.ToString(Console.ReadLine());
            string[] words= str.Split(' ');
            string revstring = "";

            for (int i = words.Length - 1; i >= 0; i--)
            { 
            revstring += words[i]+" ";

            }

            Console.WriteLine("The reversed order of the words is : "+revstring);



        }



    }
}
