using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanics.DevTools
{
    public class Movement
    {
        public (int, int, int) GetVector(int max)
        {
            //maybe use old pos to seed for funsies?
            var rnd = new Random();//i think I need to seed this right?
            return (rnd.Next(7), rnd.Next(7), rnd.Next(7));
        }
    }
}
