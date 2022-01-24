using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    class Round : Shape, ILineLengthCalculation
    {
        private Point _center;
        private double _radius;
        
        public double X { get { return _center.X; } }
        public double Y { get { return _center.Y; } }

        public double Radius { get => _radius; }
        public virtual double GetLineLength { get { return 2 * Math.PI * _radius; } }

        public Round (Point center, double radius)
            {
            _center = center;
            _radius = radius;
            }
        public override string ToString() => $"окружность: координаты центра - X:{X}, Y:{Y};  Радиус: {Radius}; Длина окружности: {GetLineLength}";
    }
}
