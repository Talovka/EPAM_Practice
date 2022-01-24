using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    class Point
    {
        private double x;
        private double y;
        public double X { get { return x; } init => x = value; }
        public double Y { get { return y; } init => y = value; }
        public Point(double x, double y) 
        {
            this.x = x;
            this.y = y;
        }
    }
}
