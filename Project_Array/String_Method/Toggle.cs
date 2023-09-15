using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.String_Method
{
    internal class Toggle
    {
        public static void Main(string[] args)
        {
            //8.Write a C# program to toggle case of each character of a string.
            string str =  "inDiA iS a bEsT" ;
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {

                if (charArray[i] >= 65 && charArray[i] <= 91)
                {

                    int a = (int)charArray[i] + 32;
                    charArray[i] = (char)a;

                }
                else 
                {
                    int A = (int)charArray[i] - 32;
                    charArray[i]=(char)A;
                
                }

            }
            Console.WriteLine(str);









        }


    }
}
