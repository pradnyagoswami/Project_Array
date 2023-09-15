using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Generic_Collection
{
    internal class HashsetClass
    {
        public static void Main(string[] args)
        { 
        
            HashSet<string> h = new HashSet<string>();
            h.Add("pune");
            h.Add("mumbai");
            h.Add("nashik");
            h.Add("pune");
            h.Add("nagpur");


            h.Remove("nashik"); // remove the single element that we specified in the argument

          //  h.Clear();// remove all the elements

            foreach (string s in h) 
            {

                Console.WriteLine(s);
            }








        }



    }
}
