using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class Frequency
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2,9,7,2,9,7,5,6,3,9,1,7 };
            Console.WriteLine("Unique number in array");

            for (int i = 0; i < arr.Length; i++)
            {

                int count = 1;
                bool isvisited = false;

                for (int k = i - 1; k >= 0; k--)
                {

                    if (arr[k] == arr[i])
                    {

                        isvisited = true;
                        break;

                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {

                        if (arr[i] == arr[j])
                        {
                            count++;

                        }
                    }
                    
                    
                        Console.WriteLine(arr[i] + "count = " + count);

                    
                }
            }

        }










        }
    }
