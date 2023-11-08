using Mechanics.Composition;

namespace Mechanics
{
    public class Trip : IEquatable<Trip>, ILocatable
    {
        public (int x, int y, int z) Value => (_x, _y, _z);

        readonly int _x;
        readonly int _y;
        readonly int _z;

        internal Trip(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        internal Trip((int x, int y, int z) trip)
        {
            _x = trip.x;
            _y = trip.y;
            _z = trip.z;
        }

        public static Trip Random()
        {
            var rnd = new Random();//i think I need to seed this right?
            return new Trip(rnd.Next(7), rnd.Next(7), rnd.Next(7));
        }

        public bool Equals(Trip? other)
        {
            return this._x == other?._x && this._y == other?._y && this._z == other?._z;
        }
    }
}