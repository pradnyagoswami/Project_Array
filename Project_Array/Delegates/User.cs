using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Array.Delegates
{
    //Create a class User, create a method with name AccpetName(string name), convert the name in upper case & return.
    //Create the delegate to hold AcceptName method reference & invoke using delegate
    public delegate string MyDelegate(string name1);
    internal class User
    {
        
        public string AcceptName(String name)
        {
            return name.ToUpper();
            
        }

        public static void Main(string[] args)
        {

            User u1 = new User();
            MyDelegate myDelegate = new MyDelegate(u1.AcceptName);
            string result = myDelegate.Invoke("pradnya");
            Console.WriteLine(result);


        }




    }
}
