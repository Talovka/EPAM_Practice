using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    class Lava: GameObject
    {
        public Lava(Point point) : base(point)
        {

        }
        public override string ToString() => "&";

        public int DamageFire(Raynor pl) 
        {
            return pl.Health= pl.Health-1;
        }
    }
}
