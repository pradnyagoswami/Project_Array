using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Collections
{
    internal class sortedList_class
    {

        public static void Main(string[] args)
        {
            //Implement dept id , dept name using SortedList

            SortedList sl = new SortedList();
            sl.Add(502,"Hr");
            sl.Add(503, "Manager");
            sl.Add(504, "sales");


            foreach(DictionaryEntry S in sl) 
            {
                Console.WriteLine($"{S.Key}->{S.Value}");

            }
        
        
        
        
        }

    }
}
