using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    class Line: Shape, ILineLengthCalculation
    {
        private Point _first;
        private Point _second;

        public double GetLineLength { get { return (int)Math.Sqrt(Math.Pow((_second.X - _first.X), 2) + Math.Pow((_second.Y - _first.Y),2)); } }

        public Line(Point first, Point second) 
        {
            _first = first;
            _second = second;
        }
        public override string GetName() => "Линия";

    }
}
