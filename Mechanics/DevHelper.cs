﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanics.DevTools
{
    public class Movement
    {
        public static (int, int, int) GetVector(int min, int max)
        {
            //maybe use old pos to seed for funsies?
            var rnd = new Random();//i think I need to seed this right?
            return (rnd.Next(min, max), rnd.Next(min, max), rnd.Next(min, max));
        }
    }
}
