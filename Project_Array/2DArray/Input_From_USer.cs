using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array._2DArray
{
    internal class Input_From_USer
    {
        public static void Main(string[] args)
        {
            int[,] arr = new int[4, 5];
                {

                for (int row = 0; row < arr.GetLength(0); row++)
                {

                    for (int col = 0; col < arr.GetLength(1); col++)
                    {

                        arr[row, col] = Convert.ToInt32(Console.ReadLine());

                    }

                }
                for (int row = 0; row < arr.GetLength(0); row++)
                {

                    for (int col = 0; col < arr.GetLength(1); col++)
                    {

                        Console.WriteLine($"[{row},{col}]= {arr[row, col]}");

                    }
                    Console.WriteLine("\n");

                }





            }
        
        
        
        
        
        
        }





    }
}
