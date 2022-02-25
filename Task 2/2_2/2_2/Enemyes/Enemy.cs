using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    abstract class Enemy: MovableObject
    {
        public Enemy(Point point) : base(point) 
        { 
            
        }
        public abstract int BeatPlayer(Raynor pl);
        
           
        
    }
}
