using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Exception_Handling
{
    internal class Exception_handling
    {//Accept a name from user & if name is empty or null then raise an exception ‘name is required’
     //( write all code in main method)  (try & catch block must be in main method)

        public static void Main(string[] args) 
        {
            try
            {
                Console.WriteLine("Enter Name");
                String name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {

                    throw new Exception("Name is Required");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            finally
            {
                Console.WriteLine("Inside finally block");



            }





        }

    }
}
