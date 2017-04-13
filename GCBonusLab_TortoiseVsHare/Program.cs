using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCBonusLab_TortoiseVsHare
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadRunner race = new ThreadRunner();
            List<Runner> entrants = new List<Runner>();
            entrants = Runner.Entrants();
            Console.WriteLine("The tortoise and hare are having a race!");
            bool run = true;
            while (run)
            {
                foreach (Runner r in entrants)
                {
                    race.Run(r);
                }
                run = race.FindWinner(entrants);
            }
            Console.ReadLine();
        }
    }
}
