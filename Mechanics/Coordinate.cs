namespace Mechanics
{
    public class Coordinate
    {
        //Interfaces, game rules and logic implementation
        public int X => _z;
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
    }
}