using Mechanics.Composition;
using Mechanics;
using System;

namespace Entities
{
    public class Submarine : ILocatable, IMoveable
    {
        Random _rand = new Random();
        //boomers, fast attack subs, frigates, sea mines, etc 
        public (int x, int y,int z) Trip { private set; get; }
        public Submarine((int, int, int) spawnPoint)
        {
            Trip = spawnPoint;
        }

        public void MoveTo((int, int, int) Target)
        {
            this.Trip = Target;
        }

        public void MoveRandom()
        {
            var t = (this.Trip.x + _rand.Next(-1, 2), this.Trip.y + _rand.Next(-1, 2), this.Trip.z + _rand.Next(-1, 2));
            MoveTo(t);            
        }
        public void Torpedo((int x, int y, int z) target) { }
    }
}