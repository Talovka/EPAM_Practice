using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    class Round : IPerimeterCalculation
    {
        private Point _center;
        private double _radius;

        public double X { get { return _center.X; } }
        public double Y { get { return _center.Y; } }
        public double GetPerimeter { get { return 2 * Math.PI * _radius; } }

        public Round (Point center, double radius)
            {
            _center = center;
            _radius = radius;

            }
    }
}
