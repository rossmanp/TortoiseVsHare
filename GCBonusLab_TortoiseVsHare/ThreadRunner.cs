using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GCBonusLab_TortoiseVsHare
{
    public class ThreadRunner
    {      
        Random rnd = new Random();

        public ThreadRunner()
        {

        }

        public void Run(Runner racer)
        {
            int chance = rnd.Next(1, 101);
            int trip = rnd.Next(1, 101);
            if (chance <= racer._move)
                {
                    racer._distance += racer._speed;
                    Console.WriteLine(racer._name + ": " + racer._distance);
                    Trip(racer);
                }  
            if (racer._tripped == 1)
            {
                racer._speed *= 2;
            }     
            if (racer._tripped > 0)
                {
                    racer._tripped--;
                }                        
            Thread.Sleep(100);                         
        }

        public void Trip(Runner racer)
        {
            int stumble = rnd.Next(1, 101);
            if (stumble <= racer._tripChance && racer._tripped == 0)
            {
                Console.WriteLine(racer._name + " tripped!");
                racer._tripped = 5;
                racer._speed /= 2;
            }
        }

        public bool FindWinner (List<Runner> entrants)
        {
            int index = entrants.FindIndex(s => s._distance >= 1000);
            if (index >= 0)
            {
                Console.WriteLine(entrants[index]._name + " won!");
                return false;                                      
            }
            else
            {
                return true;
            }                            
        }
        
    }
}
