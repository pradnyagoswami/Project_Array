using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Array.Collection_non_generic_Interface
{
    internal class Icomparer_interface
    {
        public class Player
        {
            private int runs;
            private string name;


            public Player(int runs, string name)
            {
                this.runs = runs;
                this.name = name;

            }
            public int Runs
            {

                get { return runs; }

            }
            public override string ToString()
            {
                return $"{runs},{name}";
            }

        }

        public class CheckRun : IComparer
        {
            public int Compare(object x, object y)
            {
                Player p1 = (Player)x;
                Player p2 = (Player)y;

                if (p1.Runs > p2.Runs)
                {
                    return 1;

                }
                else if (p1.Runs < p2.Runs)
                {

                    return -1;

                }
                else
                {
                    return 0;
                
                }

            }
        }


        public static void Main(string[] args)
        {

            Player sachine = new Player(6000, "sachine");
            Player virat = new Player(40000, "virat");
            CheckRun c1 = new CheckRun();

            int result = c1.Compare(sachine, virat);

            if (result == 1)
            {
                Console.WriteLine();

            }
        
        
        
        
        }

    }
}
