using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Delegates
{
    public delegate string MyDelegate11(string name);
    internal class User_Multicast
    {
        public string UppercaseMethod(String name)
        {
            return name.ToUpper();

        }
        public string LowerCaseMethod(String name)
        {
            return name.ToLower();

        }

        public static void Main(string[] args) 
        {
            User_Multicast um = new User_Multicast();
           
            MyDelegate myDelegate = new MyDelegate(um.UppercaseMethod); // assign the method reference
            myDelegate += new MyDelegate(um.LowerCaseMethod); // add method in invocation
           //myDelegate -= new MyDelegate(um.UppercaseMethod);// remove method from invocation list



            Delegate[] list = myDelegate.GetInvocationList();
            foreach (Delegate D in list) 
            {
                Console.WriteLine(D.Method);
                string result=Convert.ToString(D.DynamicInvoke("pradnya"));
                Console.WriteLine(result);



            }





        }

    }
}
