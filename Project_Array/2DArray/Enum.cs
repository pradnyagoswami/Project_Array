using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array._2DArray
{
    public enum Department { hr, admin, marketing, sales, manager }
    public enum categories { car,bike,airoplane,bus,train }
    public class Employee
    {
       private int id;
       private string name;
       private  int salary;
       private categories catogary;
       private Department dept;

        public Employee(int id,string name,int salary,categories catogary,Department dept)
        { 
            this.id = id;
            this.name = name;   
            this.salary = salary;   
            this.catogary = catogary;
            this.dept = dept;
        }
        public override string ToString()
        {
            return $"{id},{name},{salary},{catogary},{dept}";
        }
        public class Enum
        { 
         public static void Main(string[] args) 
            {
                Employee emp = new Employee(101, "radha", 35000, categories.car,Department.manager);
                Console.WriteLine(emp);
                Employee emp2 = new Employee(102, "krishna", 36000, categories.train, Department.sales);
                Console.WriteLine(emp2);
            }
        
        
        }

    }
    
    
    
    
    
    
    
    
}
