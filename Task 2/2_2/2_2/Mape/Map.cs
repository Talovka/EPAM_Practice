using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{


    class Map
    {
        private const int DefaultWeidthAndHeight = 10;
        public int Width { get; init; }
        public int Heigth { get; init; }

        private GameObject[,] arr;
        public Map(int width, int heigth)
        {
            Width = width;
            Heigth = heigth;
            arr = new GameObject[Width, Heigth];
        }
        public Map()
        {
            Width = DefaultWeidthAndHeight;
            Heigth = DefaultWeidthAndHeight;
            arr = new GameObject[Width, Heigth];
        }

    

    }
}
