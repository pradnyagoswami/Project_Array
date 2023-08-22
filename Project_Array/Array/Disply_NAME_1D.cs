using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    public class Disply_NAME_1D
    {
        public static void Main(string[] args) 
        {
            string[] name = new string[5];

            for (int i = 0; i < name.Length; i++)
            {

                Console.WriteLine("Enter names");
                name[i]= Console.ReadLine();

            }
            for (int i = 0; i < name.Length; i++ )
            {

                Console.WriteLine(name[i]);

            }





        }

       

      
    }
}
