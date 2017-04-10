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
            ThreadRunner tortoise = new ThreadRunner("Tortoise", 100, 10);
            ThreadRunner hare = new ThreadRunner("Hare", 10, 100);
            Console.WriteLine("The tortoise and hare are having a race!");
            bool DidTortoiseWin = race.Run(tortoise, hare);
            if (DidTortoiseWin == true)
            {
                Console.WriteLine("Tortoise wins!");
            }
            else
            {
                Console.WriteLine("Hare wins!");
            }
            Console.ReadLine();
        }
    }
}
