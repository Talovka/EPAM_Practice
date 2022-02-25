using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    abstract class GameObject : ILocation
    {
        public Point ItemLocation { get; protected set; }
        
        public GameObject(Point point)  
        {
            ItemLocation = point;
        }

        public abstract override string ToString();


    }
}
