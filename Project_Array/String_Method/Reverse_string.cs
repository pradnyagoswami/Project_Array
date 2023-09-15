using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.String_Method
{
    internal class Reverse_string
    {
        //10.	Write a C# program to find reverse of a string.
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str=Convert.ToString(Console.ReadLine());

            for(int i=str.Length-1; i>=0; i--) 
            {

                Console.Write(str[i]);



            }









        }





    }
}
