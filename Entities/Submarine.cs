namespace Entities
{
    public class Submarine
    {
        //boomers, fast attack subs, frigates, sea mines, etc 
        private Mechanics.Coordinate _position;
        public Mechanics.Coordinate Position => _position;
        public Submarine()
        {
                
        }

        public void Move()
        {

        }

        public void Torpedo(Mechanics.Coordinate target) { }
    }
}