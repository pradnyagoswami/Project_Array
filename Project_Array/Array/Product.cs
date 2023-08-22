using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Array
{
    public class Product
   {
        public int id { get; set; }
        public string Name { get; set; }

        public int price { get; set; }

    }
    public class Employee
    { 
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
    
    }
    public class Book
    {

        public int id { get; set; }

        public string name { get; set; }

        public int price { get; set; }



    }
    public class Programe
    {

        public static void Main(string[] args)
        {

            Product[] list = new Product[3]
                 {
                  new Product{ id=101,Name="Tv",price=35000},
                  new Product{ id=102,Name="Fridge",price=66000},
                  new Product{ id=103,Name="AC",price=90000}



                 };
            foreach (Product p in list) 
            {
                Console.WriteLine($"{p.id},{p.Name},{p.price}");

            }

            Console.WriteLine();

            Employee[] list1 = new Employee[3]
                {

                    new Employee{id=201,name="Pradnya",salary=45000 },
                    new Employee{ id=202,name="neha",salary=35000},
                    new Employee{ id=203,name="sita",salary=25000}



                };
            foreach (Employee p in list1) 
            {
                Console.WriteLine($"{p.id},{p.name},{p.salary}");

            }

            Console.WriteLine();

            Book[] list2 = new Book[2]
                {
                new Book{ id=301,name="m1",price=200},
                new Book{ id=302,name="m2",price=300}
                };
            foreach(Book p in list2) 
            {
                Console.WriteLine($"{p.id},{p.name},{p.price}");

            }

        
        
        
        }
    
    
    
    
    
    
    }
      
}
