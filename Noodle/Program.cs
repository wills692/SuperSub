using System.Net.Sockets;

namespace Noodle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //var cheese = new NetworkStream(new Socket(SocketType.Stream, ProtocolType.Udp));

            var board = new Entities.Board();
            var p1 = new Client.Player() { Name = "p1" };
            var p2 = new Client.Player() { Name = "p2" };
            board.PlacePiece(p1.Pieces);
            board.PlacePiece(p2.Pieces);
            board.NextTurn();
            for (; ; )
            {
                board.NextTurn();
                p1.TakeTurn();
                p2.TakeTurn();
                var x = Console.ReadLine();
            }
        }

    }
}