﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    interface IMovable
    {   
        Point Move(Point newpoint) { return newpoint; }
    }
}