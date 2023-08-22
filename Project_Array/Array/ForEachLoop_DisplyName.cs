using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class ForEachLoop_DisplyName
    {
        public static void Main(string[] args)
        {

            string[] name = new string[5];

            for (int i = 0; i < name.Length; i++)
            {

                Console.WriteLine("Enter names");
                name[i] = Console.ReadLine();

            }
            foreach (string s1 in name) 
            {

                Console.WriteLine(s1);


            }




        }




    }
}
