using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Cube
    {
        public readonly Mechanics.Coordinate Trip;

        public Cube(Mechanics.Coordinate trip)
        {
            Trip = trip;
        }
    }
}
