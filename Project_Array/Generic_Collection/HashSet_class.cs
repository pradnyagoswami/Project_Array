using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Generic_Collection
{
    internal class HashSet_class
    {
        public static void Main(string[] args)
        { 
        
            HashSet<string> list1 = new HashSet<string>();
            list1.Add("c");
            list1.Add("c++");
            list1.Add("c#");
            list1.Add("java");


            HashSet<string> list2=new HashSet<string>();
            list2.Add("angular");
            list2.Add("c++");
            list2.Add("paython");
            list2.Add("java");


            // combine the result & display unqiue elements
             list1.UnionWith(list2);

            // first list matched with second & only matched elements will be displayed
            //list1.IntersectWith(list2);

            // compare first list with second & only unique elemetns from list1 get accepted
            //list1.ExceptWith(list2);

            foreach (string item in list1)
            {

                Console.WriteLine(item);
            }





        }


    }
}
