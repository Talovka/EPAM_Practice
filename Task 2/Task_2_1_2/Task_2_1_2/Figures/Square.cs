using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    class Square: Rectangle
    {
        private Point _first;
        private double _side;

        public double Side { get=> _side;}
        public Square(Point first, double side): base(first,side,side)
        {
            _first = first;
            _side = side;
        }
        public override string ToString() => $"квадрат со сторонами {Side}; Периметр квадрата: {GetPerimeter}; Площадь квадрата: {GetArea}";
    }
}
