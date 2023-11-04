using Mechanics.Composition;
using Mechanics;

namespace Entities
{
    public class Submarine : ILocatable, IMoveable
    {
        //boomers, fast attack subs, frigates, sea mines, etc 
        public (int, int, int) Trip { private set; get; }
        public Submarine((int, int, int) spawnPoint)
        {
            Trip = spawnPoint;
        }

        public void MoveTo((int, int, int) Target)
        {

        }

        public void Torpedo((int x, int y, int z) target) { }
    }
}