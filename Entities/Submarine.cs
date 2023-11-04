using Mechanics.Composition;
using Mechanics;

namespace Entities
{
    public class Submarine : ILocatable, IMoveable
    {
        //boomers, fast attack subs, frigates, sea mines, etc 
        public Coordinate Location { private set; get; }
        public Submarine(Coordinate spawnPoint)
        {
            Location = spawnPoint;
        }

        public void MoveTo(Coordinate target)
        {

        }

        public void Torpedo(Mechanics.Coordinate target) { }
    }
}