using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    class Triangle: Shape, IAreaCalculation, IPerimeterCalculation
    {

        private Point _first;
        private Point _second;
        private Point _third;

        private Line _line1;
        private Line _line2;
        private Line _line3;

        public double GetArea { get => Math.Sqrt(P * (P - GetLine1Length) * (P - GetLine2Length) * (P - GetLine3Length)); }
        public double GetPerimeter { get { return GetLine1Length + GetLine2Length + GetLine3Length; } }
        public double GetLine1Length { get => _line1.GetLineLength; }
        public double GetLine2Length { get => _line2.GetLineLength; }
        public double GetLine3Length { get => _line3.GetLineLength; }
        public Triangle(Point first, Point second, Point third) 
        {
            _first = first;
            _second = second;
            _third = third;
            _line1 = new Line(_first, _second);
            _line2 = new Line(_second, _third);
            _line3 = new Line(_third, _first);
        }
        private double P=>(GetLine1Length+GetLine2Length+GetLine3Length)/2;
        public override string ToString() => $"треугольник со сторонами: {GetLine1Length}, {GetLine2Length}, {GetLine3Length}";
    }
}
