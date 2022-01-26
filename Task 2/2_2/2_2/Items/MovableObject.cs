using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    abstract class MovableObject: GameObject, IMovable
    {
        private int _health;
        public int Health
        {  
            get => _health;
            set
            {
                if (_health > 0)
                {
                    _health = value;
                }
                else 
                {
                    _health = 0;
                }
            }
        }
        public MovableObject(Point point): base (point) 
        {
            
        }
        public virtual Point Move(Point newpoint) 
        {
            return ItemLocation = newpoint;
        }
    }
}
