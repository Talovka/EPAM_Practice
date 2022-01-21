using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    class Rectangle: Shape
    {
        private Point _first;
        private Point _second;
        private Point _third;
        private Point _fourth;
        public override double GetPerimeter { get; }
        public override double GetArea { get; }
        
        public Rectangle(Point first, Point second, Point third, Point fourth)
        {
            _first = first;
            _second = second;
            _third = third;
            _fourth = fourth;
        }
    }
}
