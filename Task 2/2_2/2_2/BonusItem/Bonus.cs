using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    abstract class Bonus:GameObject
    {

        public Bonus(Point point) : base(point) 
        {

        }
        public abstract int BonusEffect(Raynor pl);
                   
    }
}
