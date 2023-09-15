using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Generic_Interfaces
{
    public class Employee
    {
        public string name { get; set; }
        public int salary { get; set; }

    }
    public class Checksalary : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.salary > y.salary)
            {

                return 1;

            }
            else if (x.salary < y.salary)
            {

                return -1;

            }
            else 
            {

                return 0;
            
            }
        }
    }
    public class program
    { 
    
        public static void Main(string[] args) 
        {
            Employee emp1 = new Employee { name = "pradnya", salary = 45000 };
            Employee emp2 = new Employee { name = "sneha", salary = 45000 };

            Checksalary ck=new Checksalary();
            int result= ck.Compare(emp1, emp2);
            if (result == 1)
            {

                Console.WriteLine("Pradnya has higher salary than sneha");
            }
            else if (result == -1)
            {

                Console.WriteLine("Sneha has higher salary than pradnya");

            }
            else
            {
                Console.WriteLine("Both has equal salary");

            }

        
        
        
        
        }
    
    
    
    
    
    
    
    }




}
