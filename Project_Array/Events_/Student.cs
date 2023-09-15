using Project_Array.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Events_
{
    public delegate void MyDelegate1();
    public class Student
    {
        //when event raise then notification will be sent to MyDelegate
        public event MyDelegate1 Fail;
        public event MyDelegate1 Pass;

        public void AcceptPercentage(double per)
        {

            if (per < 45)
            {


                Fail();


            }
            else
            {
                Pass();
            }

        }
    }

    public class Message
    {
        //public void SuccesMessage()
        //{
        //    Console.WriteLine("Your pass in exam");

        //}
        //public void FailMessage()
        //{

        //    Console.WriteLine("your fail in exam");
        //}



    }
    public class Program3
    {

        public static void Main(string[] args)
        {
            try
            {

                Student s = new Student();
                Message message = new Message();
                // bind event with delegate
                //s.Fail += new MyDelegate1(message.FailMessage);
                //s.Pass += new MyDelegate1(message.SuccesMessage);


                s.Fail += delegate () { Console.WriteLine("You are fail"); };//Anonymous with delegate
                s.Pass += delegate () { Console.WriteLine("You are pass"); };


                s.AcceptPercentage(50);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            
            }
           





        }

    }

        


    }


