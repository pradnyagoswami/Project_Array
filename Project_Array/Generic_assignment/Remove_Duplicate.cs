using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Generic_assignment
{
    internal class Remove_Duplicate
    {
        //create a List And Remove duplicate from List
        public static void Main(string[] args)
        { 
        
            List<int> list = new List<int>();
            list.Add(202);
            list.Add(203);
            list.Add(206);
            list.Add(202);
            list.Add(203);
            list.Add(208);
            list.Add(202);

            
            for(int i=0; i<list.Count; i++) 
            {
            
                for(int j=i+1; j<list.Count; j++) 
                {

                    if (list[i]==( list[j]))
                    {
                        
                        list.RemoveAt(j);
                        j--;


                    }
                
                
                }
                Console.WriteLine(list[i]);


            }

        
        
        }


    }
}
