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
        private double _length;
        private double _heigth;
        public  double GetPerimeter { get { return _heigth * 2 + _length * 2; } }
        public  double GetArea { get { return _heigth * _length; } }

        public double Heigth { get=> _heigth;}
        public double Length { get => _length; }
        public Rectangle(Point first, double heigth, double length)
        {
            _first = first;
            _length = length;
            _heigth = heigth;        
        }
        public override string ToString() => $" прямоугольник со сторонами {Heigth}, {Length}; Периметр прямоугольника: {GetPerimeter}; Площадь прямоугольника: {GetArea} ";
    }
}
