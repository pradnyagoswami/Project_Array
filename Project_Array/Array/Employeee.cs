using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    public class Employeee
    {
       private  int id;
        private  string name;
        private int slary;

        public Employeee(int id, string name, int salary)
        { 
        
            this.id = id;
            this.name = name;
            this.slary = salary;    
        
        }
        public override string ToString()
        {

            return $"{id},{name},{slary}";
        
        }
        public static void Main(string[] args)
        {

            //Employeee[] emp = new Employeee[3];
            //emp[0] = new Employeee(501,"rahul",35000);
            //emp[1] = new Employeee(502,"Anjali",25000);
            //emp[2] = new Employeee(503,"Tina",15000);

            //foreach (Employeee e in emp) 
            //{
            //    Console.WriteLine(e);

            //}

            //Taking input from user
            Employeee[] emp = new Employeee[3];
            for (int i = 0; i < emp.Length; i++)
            {

                Console.WriteLine("Enter id");
                int id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name");
                string name=Console.ReadLine();
                Console.WriteLine("Enter Salary");
                int salary=Convert.ToInt32(Console.ReadLine());

                emp[i]=new Employeee(id, name, salary);

            }


            for (int i = 0; i < emp.Length; i++)
            {

                Console.WriteLine(emp[i]);

            }


        }
    }
}
