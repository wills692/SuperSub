namespace Mechanics
{
    public class Coordinate
    {
        //Interfaces, game rules and logic implementation
        public int X => _x;
        public int Y => _y;
        public int Z => _z;

        readonly int _x;
        readonly int _y;
        readonly int _z;

        public Coordinate(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public static Coordinate operator +(Coordinate a, Coordinate b)
        {
            //this is cool
            var pt = new Coordinate(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
            return pt;
        }

        public static Coordinate Random()
        {
            var rnd = new Random();//i think I need to seed this right?
            return new Coordinate(rnd.Next(7), rnd.Next(7), rnd.Next(7));
        }
    }
}