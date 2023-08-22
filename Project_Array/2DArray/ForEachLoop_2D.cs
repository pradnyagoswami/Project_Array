using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array._2DArray
{
    internal class ForEachLoop_2D
    {


        public static void Main(string[] args)
        {
            int[,] arr = new int[4, 5]
                    {
                    { 10,20,30,40,50},
                    { 60,70,80,90,100},
                    { 110,120,130,140,150},
                    { 160,170,180,190,200 }

                    };

           foreach (int i in arr) 
            {

                Console.WriteLine(i);

            }



        }
       





    }
}
