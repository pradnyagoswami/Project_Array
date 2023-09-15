using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class Reverse_String
    {
        public static void Main(string[] args)
        {

            string[] str = { "india is the best" };
            string s = "";
            for (int i = str.Length-1;i>=0; i--)
            {
                s = s + str[i];
            }
            Console.WriteLine(s);

        }





    }
}
