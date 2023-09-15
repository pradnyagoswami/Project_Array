using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Generic_Collection
{
    internal class Dictionary_class
    {
        public static void Main(string[] args)
        { 
            Dictionary<int,string> dictionary=new Dictionary<int,string>();
            dictionary.Add(202, "Manager");
            dictionary.Add(203, "HR");
            dictionary.Add(204, "Sales");
            dictionary.Add(205, "Marketing");

            foreach (KeyValuePair<int, string> kvp in dictionary)
            {

                Console.WriteLine($"{kvp.Key},{kvp.Value}");


            }

            Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
            dictionary2.Add(".cs", "c#");
            dictionary2.Add(".txt", "Documents");

            foreach (KeyValuePair<string, string> kvp1 in dictionary2)
            {
                Console.WriteLine($"{kvp1.Key},{kvp1.Value}");

            }

            Dictionary<int,string> dictionary3=new Dictionary<int,string>();
            dictionary3.Add(91,"India");
            dictionary3.Add(41, "Korea");
            dictionary3.Add(01, "us");

            foreach (KeyValuePair<int, string> kvp2 in dictionary3)
            {

                Console.WriteLine($"{kvp2.Key},{kvp2.Value}");

            }





        


        
        
        
        
        }








    }
}
