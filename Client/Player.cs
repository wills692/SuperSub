using Mechanics;
namespace Client
{
    public class Player
    {
        public string Name { get; set; }
        public Network.Address Naddy { get; set; }
        public Entities.Submarine MyBoat { get; set; } = new Entities.Submarine(Coordinate.Random());
    }
}