using System.Net.Sockets;

namespace Noodle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var board = new Entities.Board();
            var p1 = new Client.Player() { Name = "p1" };
            var p2 = new Client.Player() { Name = "p2" };
            board.Pieces.AddRange(p1.Pieces);
            board.Pieces.AddRange(p2.Pieces);
            for (; ; )
            {
                board.Tick();
                p1.TakeTurn();
                p2.TakeTurn();
                var x = Console.ReadLine();
            }
        }

    }
}