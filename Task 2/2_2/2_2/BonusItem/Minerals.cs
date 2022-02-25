using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    class Minerals: Bonus
    {
        public Minerals (Point point) : base(point)
        {

        }

        public override int BonusEffect(Raynor pl)
        {
            return pl.Level = pl.Level+1;
        }
        public override string ToString() => "^";
    }
}
