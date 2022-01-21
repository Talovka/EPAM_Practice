using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    class Circle: Round, IAreaCalculation
    {
        private double _radius;
        public Circle (Point center, double radius): base(center, radius) { _radius = radius; }

        public double GetArea { get { return Math.PI*_radius*_radius; } }

    }
}
