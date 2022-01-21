using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    class Ring: Circle
    {
        private double _innerradius;
        private double _radius;

        public Ring(Point center, double radius, double innerradius): base(center,radius) 
        {
            _innerradius = innerradius;
            this._radius = radius;
        }
        public double GetInnerLineLength{ get { return 2 * Math.PI * _innerradius; }}
        public double GetRingArea { get { return Math.PI * (_radius * _radius - _innerradius * _innerradius); } }
        public override string GetName() => "Кольцо";
    }
}
