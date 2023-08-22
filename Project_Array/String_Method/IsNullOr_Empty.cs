using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.String_Method
{
    internal class IsNullOr_Empty
    {
        public static void Main(string[] args)
        {

            string st = null;
            if (string.IsNullOrEmpty(st))
            {

                Console.WriteLine("String is empty");

            }
            Console.WriteLine(st);

            Console.WriteLine("Enter name");
            string name=Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {

                Console.WriteLine("name is required");


            }
            else
            {

                Console.WriteLine("hello "+name);


            }


        }



    }
}
