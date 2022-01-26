using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    class GunPatron:Bonus
    {
         
        public GunPatron(Point point) : base(point)
        {

        }

        public override int BonusEffect(Raynor pl) 
        {

            return pl.GunCapacity= pl.GunCapacity+1;
        }
        public override string ToString() => "#";
        
    }
}
