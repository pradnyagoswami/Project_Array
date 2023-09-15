using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Collections
{
    internal class Hashtable_class
    {
        public static void Main(string[] args)
        {
            //Implement country code & country name using Hashtable

            Hashtable ht = new Hashtable();
            ht.Add(91, "India");
            ht.Add(01, "usa");
            ht.Add(41, "s-korea");

            ht.Remove(01);// based on key data will be removed from the hashtable

            foreach (DictionaryEntry H in ht)
            {
                Console.WriteLine($"{H.Key}-> {H.Value}");

            }








        }



    }
}
