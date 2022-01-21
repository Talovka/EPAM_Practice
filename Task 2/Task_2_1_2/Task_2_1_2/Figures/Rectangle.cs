using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    class Rectangle: Shape, IAreaCalculation, IPerimeterCalculation
    {
        private Point _first;
        private double _weight;
        private double _height;
        public  double GetPerimeter { get { return _height * 2 + _weight * 2; } }
        public  double GetArea { get { return _height * _weight; } }

        public Rectangle(Point first, double height, double weight)
        {
            _first = first;
            _weight = weight;
            _height = height;        
        }
        public override string GetName() => "Прямоугольник";
    }
}
