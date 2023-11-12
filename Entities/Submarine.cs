using Mechanics.Composition;
using Mechanics;
using System;

namespace Entities
{
    public class Submarine : IMoveable
    {
        public Trip Location { private set; get; }
        public (int x, int y, int z) Vector { private set; get; }
        public Submarine(Trip location)
        {
            Location = location;
        }

        public void MakeHeading((int x, int y, int z) vector)
        {
            this.Vector = vector;
        }

        public void Move()
        {
            this.Location = this.Location + new Trip(Vector);
        }
    }
}