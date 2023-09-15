using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Generic_assignment
{
    internal class Name_AscendingOrder
    {
        //2.WAP to create an array of 5 strings to store students name,
        //sort names in ascending order & display using foreach loop.
        public static void Main(string[] args)
        {
           
            List<string> list = new List<string>();
            list.Add("pooja");
            list.Add("neha");
            list.Add("aman");
            list.Add("harsh");
            list.Add("mrunali");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);


            }






        }


    }
}
