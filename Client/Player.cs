using Mechanics;
using Mechanics.Composition;

using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;

namespace Client
{
    public class Player
    {
        private readonly bool _isNpc;
        public string Name { get; set; }
        public Network.Address Naddy { get; set; }
        public Entities.Submarine MyBoat { get; set; }

        public List<ILocatable> Pieces { get; set; } = new List<ILocatable> { };
        private List<IMoveable> Moveables => Pieces.OfType<IMoveable>().ToList();

        public Player(bool isNpc = false)
        {
            _isNpc = isNpc;
            MyBoat = new Entities.Submarine(Trip.Random());
            Pieces.Add(MyBoat);
        }

        private List<ConsoleKey> MovementKeys = new List<ConsoleKey>();
        public void TakeTurn()
        {
            if (MovementKeys.Count == 0)
            {
                MovementKeys.Add(ConsoleKey.DownArrow);
                MovementKeys.Add(ConsoleKey.LeftArrow);
                MovementKeys.Add(ConsoleKey.RightArrow);
                MovementKeys.Add(ConsoleKey.UpArrow); 
            }

            foreach (var m in Moveables)
            {
                if (_isNpc)
                    m.MakeHeading(Mechanics.DevTools.Movement.GetVector(1));
                else
                {
                    //prompt or teletype msg Take your turn
                    var q = Console.ReadKey(true).Key;
                    while (!MovementKeys.Contains(q)) { q = Console.ReadKey(true).Key; }
                    m.MakeHeading()
                    Debugger.Break();
                }
                m.Move();
            }
        }
    }
}