using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.String_Method
{
    internal class Methods_OF_String
    {
        public static void Main(string[] args)
        {

            string message = "Hello World";
            string message2 = "Good Morning";

            //Method of string
            //1)Concat
            string str=string.Concat(message,' ' ,message2.TrimEnd());
            Console.WriteLine(str);
            Console.WriteLine(str.Trim());

            //2)Toupper(),ToLower();
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message.ToLower());

            //3)IndexOf();

            Console.WriteLine("Index = "+message.IndexOf('0'));// return the first occurance
            Console.WriteLine("Index = "+message.LastIndexOf('o'));

            //4)conver string to array
            string[] str2 = message.Split(' ');

            // convert string to char array
            char[] ch = message.ToCharArray();

            // convert char array to a string
            string str3 = new string(ch);
            Console.WriteLine(str3);

            foreach (char c in ch)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(str[0]);// Good
            Console.WriteLine(str[1]); // morning

            foreach (string s in str2)
            {
                Console.WriteLine(s);
            }

            for (int i = 0; i < message2.Length; i++)
            {
                Console.WriteLine(message2[i]);
            }
        }









    }












}

