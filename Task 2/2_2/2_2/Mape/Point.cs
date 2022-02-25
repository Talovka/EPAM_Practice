using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    class Point
    {
        public int X { get; init; }
        public int Y { get; init; }     
        public Point(int x, int y)
        {
            X = x;
            Y = y;         
        }
        public override string ToString()
        {
            return $"({ X }, { Y })";
        }
    }
}
