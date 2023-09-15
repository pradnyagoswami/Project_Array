using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.String_Method
{
    internal class StringBuilder_Method 
    {
        public static void Main(string[] args)
        { 
        
            StringBuilder sb = new StringBuilder("Hello to all");
            Console.WriteLine(sb);

            sb.Append("Good Morning");
            Console.WriteLine(sb);

            sb.Remove(4,5);
            Console.WriteLine(sb);

            sb.Replace('o','@');
            Console.WriteLine(sb);

            sb.Replace("To ","to the");
            Console.WriteLine(sb);

            Console.WriteLine("capacity = "+sb.Capacity);

            sb.Clear();
            Console.WriteLine(sb);
















        }







    }
}
