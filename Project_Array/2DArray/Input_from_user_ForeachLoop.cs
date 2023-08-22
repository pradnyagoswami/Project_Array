using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array._2DArray
{
    internal class Input_from_user_ForeachLoop
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
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }

                }



            }

            }







        }

