using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Collection_non_generic_Interface
{
    public class Player
    {
        private int runs;
        private string name;

        public Player(int runs,string name)
        { 
            this.runs = runs;
            this.name = name;
        
        }
    
       public override string ToString() 
        {

            return $"{runs},{name}";
        
        }
    }
    public class Team : IEnumerable
    {

        private Player[] Players;
        public Team()
        {
            Players = new Player[3]
            {
              new Player(500020,"virat"),
              new Player(40000,"Abd"),
              new Player(30000,"roahit")

            };
       
        }

        public IEnumerator GetEnumerator()
        {
            return Players.GetEnumerator(); 
        }
    }


    public class Program
    {

        public static void Main(string[] args)
        {

            Team team = new Team();
            foreach (Player p in team)
            {

                Console.WriteLine(p);
            }
        
        }

    }
}
