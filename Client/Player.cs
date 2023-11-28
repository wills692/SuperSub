using Mechanics;
using Mechanics.Composition;
using System.Net;

namespace Client
{
    public class Player
    {
        private Random _random = new Random();
        public string Name { get; set; }
        public Network.Address Naddy { get; set; }
        public Entities.Submarine MyBoat { get; set; }

        public List<ILocatable> Pieces { get; set; } = new List<ILocatable> { };
        private List<IMoveable> Moveables => Pieces.OfType<IMoveable>().ToList();

        public Player()
        {
            MyBoat = new Entities.Submarine(Trip.Random());
            Pieces.Add(MyBoat);
        }

        public void TakeTurn()
        {
            foreach (var m in Moveables)
            {
                m.MakeHeading(Mechanics.DevTools.Movement.GetVector(-5, 5));
                m.Move();
            }
        }
    }
}