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
        public double InnerRadius { get => _innerradius; }
        public override double GetLineLength { get { return 2 * Math.PI * _innerradius + 2 * Math.PI * _radius; }}
        public override double GetArea { get { return Math.PI * (_radius * _radius - _innerradius * _innerradius); } }
        public override string ToString() => $"кольцо: координаты центра:  X:{X}, Y:{Y}; Внешний радиус: {Radius}; Внутренний радиус: {InnerRadius}; Длина кольца: {GetLineLength}; Площадь кольца: {GetArea}";
    }
}
