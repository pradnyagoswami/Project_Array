using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.String_Method
{
    internal class alphabate_digit_character
    {
        //13.Write a C# program to find total number of alphabets, digits or special character in a string.
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Convert.ToString(Console.ReadLine());
            int count_al = 0;
            int count_dig = 0;
            int count_sc = 0;


            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] >= 'a' && str[i] <= 'z')
                {

                    count_al++;


                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    count_dig++;


                }
                else 
                {

                    count_sc++;

                
                }
            
            }
            Console.WriteLine($" Alphabates in array = {count_al},Digits in array ={count_dig},special character in array = {count_sc}");



        }



    }
}
