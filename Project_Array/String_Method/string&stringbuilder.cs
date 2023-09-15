using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.String_Method
{
    internal class string_stringbuilder
    {

        public static void Main(string[] args)
        {
            string str1 = "Hello to all";
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());// address

            str1 = str1 + "Good Morning";
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());

            Console.WriteLine("------- StringBuilder class------");
            StringBuilder strbuilder = new StringBuilder("Hello to all");
            Console.WriteLine(strbuilder);
            Console.WriteLine(strbuilder.GetHashCode());// address

            strbuilder.Append("Good Morning");
            Console.WriteLine(strbuilder);
            Console.WriteLine(strbuilder.GetHashCode());
        }

    }
}
