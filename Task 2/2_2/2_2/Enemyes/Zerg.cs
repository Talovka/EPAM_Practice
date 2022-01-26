using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    class Zerg: Enemy
    {
        private const int _health = 1;

        Zerg(Point point): base(point) 
        {
            Health = _health;
            
        }
        public override int BeatPlayer(Raynor pl)
        {
            return pl.Health = pl.Health - 1;
        }

        public override string ToString() => "*";
    }
}
