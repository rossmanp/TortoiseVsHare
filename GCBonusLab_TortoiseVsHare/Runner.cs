using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCBonusLab_TortoiseVsHare
{
    public class Runner
    {
        public string _name { get; private set; }
        public int _move { get; private set; }
        public int _speed { get; set; }
        public int _distance { get; set; }
        public int _tripChance { get; private set; }
        public int _tripped { get; set; }

        public Runner(string name, int move, int speed, int distance, int tripChance, int tripped)
        {
            this._name = name;
            this._move = move;
            this._speed = speed;
            this._distance = distance;
            this._tripChance = tripChance;
            this._tripped = tripped;
        }

        public static List<Runner> Entrants()
        {
            List<Runner> entrants = new List<Runner>();
            entrants.Add(new Runner("Greyhound", 20, 50, 0, 5, 0));
            entrants.Add(new Runner("Hare", 10, 100, 0, 10, 0));
            entrants.Add(new Runner("Tortoise", 100, 10, 0, 0, 0));
            return entrants;
        }
    }
}
