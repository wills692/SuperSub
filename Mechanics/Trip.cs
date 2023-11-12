using Mechanics.Composition;

namespace Mechanics
{
    public class Trip : IEquatable<Trip>
    {
        public (int x, int y, int z) Value => (_x, _y, _z);

        readonly int _x;
        readonly int _y;
        readonly int _z;

        public Trip(int x, int y, int z)
        {
            _x = x % Console.WindowWidth;
            _y = y % Console.WindowHeight;
            _z = z;
        }

        public Trip((int x, int y, int z) trip)
        {
            _x = trip.x % Console.WindowWidth;
            _y = trip.y % Console.WindowHeight;
            _z = trip.z;
        }

        public static Trip Random()
        {
            var rnd = new Random();//i think I need to seed this right?
            return new Trip(rnd.Next(Console.WindowWidth - 1), rnd.Next(Console.WindowHeight - 1), rnd.Next(7));
        }

        public bool Equals(Trip? other)
        {
            return this._x == other?._x && this._y == other?._y && this._z == other?._z;
        }

        public static Trip operator +(Trip? left, Trip? right)
        {
            var w = (left?._x ?? 0) + (right?._x ?? 0);
            var h = (left?._y ?? 0) + (right?._y ?? 0);
            var d = (left?._z ?? 0) + (right?._z ?? 0);
            //^^^ parens reqd for it to evaluate correctly 
            return new Trip(w, h, d);
        }


    }
}