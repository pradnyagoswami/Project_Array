using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Collection_non_generic_Interface
{
    public class Product:IComparable
    {
        private int price;
        private string name;

        public Product(int price, string name)
        {

            this.price = price;
            this.name = name;
        
        }

        public int CompareTo(object obj)
        {
            // convert object to player class
            Product p = (Product)obj;
            if (this.price > p.price)
            {
                return 1;
            }
            else if (this.price < p.price)
            {
                return -1;
            }
            else 
            {
                return 0;
            
            }

        }

        public override string ToString()
        {
            return $"{price},{name}";
        }
    }
    internal class Icomaprable_Product
    {
        public static void Main(string[] args)
        {
            Product eyeshadow = new Product(5000, "Eyeshadow");
            Product Compact = new Product(35000 ,"Comapct");

            int price=eyeshadow.CompareTo(Compact);
            if (price == 1)
            {
                Console.WriteLine("Eyeshadow is costly than compact");
            }
            else if (price == -1)
            {
                Console.WriteLine("Eyeshadow is cheaper than compact");
            }
            else
            {
                Console.WriteLine("Both has equal price");
            }

        }

        



    }
}
