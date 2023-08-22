using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    internal class Employe1
    {
        int id;
        string name;
        int salary;

        public Employe1(int id,string name,int salary)
        { 
            this.id = id;
            this.name = name;   
            this.salary = salary;
        
        }
        public override string ToString()
        {

            return $"{id},{name},{salary}";

        }




        public static void Main(string[] args)
        {
            Employe1[] emp = new Employe1[3];
            for (int i = 0; i < emp.Length; i++)
            {

                Console.WriteLine("Enter id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Salary");
                int salary = Convert.ToInt32(Console.ReadLine());

                emp[i] = new Employe1(id, name, salary);

               

            }
            for (int i = 0; i < emp.Length; i++)
            {

                if (emp[i].salary > 20000)
                {

                    Console.WriteLine(emp[i]);

                }
            
            
            }

            


          /*  for (int i = 0; i < emp.Length; i++)
            {

                Console.WriteLine(emp[i]);

            }*/




        }

    }
}
