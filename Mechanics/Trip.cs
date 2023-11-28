using Mechanics.Composition;
using System.Diagnostics;

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
            _x = (x % Console.WindowWidth) < 0 ? (Console.WindowWidth - (x % Console.WindowWidth)) : (x % Console.WindowWidth);
            _y = (y % Console.WindowHeight) < 0 ? (Console.WindowHeight - (y % Console.WindowHeight)) : (y % Console.WindowHeight);
            _z = z;
            Debug.Assert(x >= 0 && x <= Console.WindowWidth);
            Debug.Assert(y >= 0 && y <= Console.WindowHeight);
        }

        public Trip((int x, int y, int z) trip) : this(trip.x, trip.y, trip.z) { }

        public static Trip Random()
        {
            var rnd = new Random((int)DateTime.Now.Ticks);//i think I need to seed this right?
            return new Trip(rnd.Next(Console.WindowWidth - 1), rnd.Next(Console.WindowHeight - 1), rnd.Next(7));
        }

        public bool Equals(Trip? other)
        {
            return this._x == other?._x && this._y == other?._y && this._z == other?._z;
        }

        public static Trip operator +(Trip? left, Trip? right)
        {
            return new Trip((left?._x ?? 0) + (right?._x ?? 0),
                            (left?._y ?? 0) + (right?._y ?? 0),
                            (left?._z ?? 0) + (right?._z ?? 0));
                        //^^^ parens reqd for it to evaluate correctly 
        }


    }
}