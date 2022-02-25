using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    class Raynor : MovableObject
    { private const int Consthealth = 10;
        private const int Constlevel = 1;
        private const int Constguncapacity = 10;
        private const int MaxHealth = 15;
        private const int Maxlevel = 5;
        private const int Maxguncapacity = 15;

        private int _health;
        private int _level;
        private int _guncapacity;      
        public int Level 
        { 
            get=> _level;  
            set
            {
                if (_level < Maxlevel)
                {
                    _level = value;
                }
                else 
                {
                    _level = Maxlevel;
                }
                 
            }
        }
        public int GunCapacity 
        { 
            get=> _guncapacity; 
            set
            {
                if (_guncapacity < Maxguncapacity)
                {
                    _guncapacity = value;
                }
                else
                {
                    _guncapacity = Maxguncapacity;
                }
            }
        }
        
        public int PointX { get; set; }
        public int PointY { get; set; }
        public Raynor(Point point): base (point)
        {
            PointX = point.X;
            PointY = point.Y;
            _health = Consthealth;
            _level = Constlevel;
            _guncapacity = Constguncapacity;
        }
        public override string ToString() =>("$");


    }
}
