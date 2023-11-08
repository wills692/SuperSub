using Mechanics.Composition;
using Mechanics;
using System;

namespace Entities
{
    public class Submarine : ILocatable, IMoveable
    {
        Random _rand = new Random();
        //boomers, fast attack subs, frigates, sea mines, etc 
        public Trip Location { private set; get; }
        public Submarine(Trip spawnPoint)
        {
            Value = spawnPoint;
        }

        public void MoveTo((int, int, int) Target)
        {
            this.Value = Target;
        }

        public void MoveRandom()
        {
            var t = (this.Value.x + _rand.Next(-1, 2), this.Value.y + _rand.Next(-1, 2), this.Value.z + _rand.Next(-1, 2));
            MoveTo(t);            
        }
        public void Torpedo((int x, int y, int z) target) { }
    }
}