using Mechanics.Composition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanics
{
    public class Cube
    {
        public readonly Mechanics.Coordinate Position;
        public HashSet<ILocatable> Pieces { get; set; } = new HashSet<ILocatable>();    

        public Cube((int x, int y, int z) trip)
        {
            this.Position = new Coordinate(trip);
        }


    }
}
