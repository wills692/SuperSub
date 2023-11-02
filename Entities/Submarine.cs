using Mechanics.Composition;
using Mechanics;

namespace Entities
{
    public class Submarine : ILocatable
    {
        //boomers, fast attack subs, frigates, sea mines, etc 
        private Mechanics.Coordinate _location;
        public Mechanics.Coordinate Location => _location;
        public Submarine()
        {
                
        }

        public void Move(Coordinate target)
        {

        }

        public void Torpedo(Mechanics.Coordinate target) { }
    }
}