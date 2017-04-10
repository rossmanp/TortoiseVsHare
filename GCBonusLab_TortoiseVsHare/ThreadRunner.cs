using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GCBonusLab_TortoiseVsHare
{
    public class ThreadRunner
    {
        public string _name { get; private set; }
        public int _move { get; private set; }
        public int _speed { get; private set; }
        private int _distance = 0;
        Random rnd = new Random();

        public ThreadRunner()
        {

        }

        public ThreadRunner(string name, int move, int speed)
        {
            this._name = name;
            this._move = move;
            this._speed = speed;           
        }

        public bool Run(ThreadRunner tortoise, ThreadRunner hare)
        {
            int chance = 0;
            for (int i = 1; tortoise._distance < 1000; i++)
            {
                chance = rnd.Next(1, 101);
                if (chance <= tortoise._move)
                {
                    tortoise._distance += tortoise._speed;
                }
                if (chance <= hare._move)
                {
                    hare._distance += hare._speed;
                }              
                Console.WriteLine("\nThe tortoise has moved " + tortoise._distance + " meters and the hare has moved " + hare._distance + " meters.");
                Thread.Sleep(100);
                if (hare._distance >= 1000)
                {
                    break;
                }
            }
            if (tortoise._distance >= 1000)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
