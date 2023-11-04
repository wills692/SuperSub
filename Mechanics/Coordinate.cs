using Mechanics.Composition;

namespace Mechanics
{
    public class Coordinate : IEquatable<Coordinate>, ILocatable
    {
        //Interfaces, game rules and logic implementation
        //public int X => _x;
        //public int Y => _y;
        //public int Z => _z;

        public (int x, int y, int z) Trip => (_x, _y, _z);

        readonly int _x;
        readonly int _y;
        readonly int _z;

        internal Coordinate(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        internal Coordinate((int x, int y, int z) trip)
        {
            _x = trip.x;
            _y = trip.y;
            _z = trip.z;
        }

        public static Coordinate operator +(Coordinate a, Coordinate b)
        {
            var foo = a.Trip; 
            var bar = b.Trip;
            //this is cool
            var pt = new Coordinate(foo.x +  bar.x, foo.y + bar.y, foo.z + bar.z);
            return pt;
        }

        public static (int x, int y, int z) Random()
        {
            var rnd = new Random();//i think I need to seed this right?
            return (rnd.Next(7), rnd.Next(7), rnd.Next(7));
        }

        public bool Equals(Coordinate? other)
        {
            throw new NotImplementedException();
        }
    }
}