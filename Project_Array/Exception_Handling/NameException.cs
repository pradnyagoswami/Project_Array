using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Array.Exception_Handling
{
    //Create Custom exception class NameExceptionUse / create Student class , accept the name from
    //constructor & if name is empty or null then raise an exception ie.NameException with message
    //‘name is required’

    internal class NameException:Exception
    {
        public NameException(string error) :base(error) 
        {
            //Console.WriteLine("Enter Name");
            //String name = Console.ReadLine();

        }

    }
    public class Student
    { 
        public Student(string name) 
        {

            if (string.IsNullOrEmpty(name))
            {
                throw new NameException(" Student Name is Required");

            }
                
        }
    
    }
    public class Program
    {
        public static void Main(string[] args) 
        {
            try
            {
                Student s = new Student(null);

            }
            catch (NameException n)
            {
                Console.WriteLine(n.Message);
            
            }
        
        
        }
    
    
    
    
    
    }

}
