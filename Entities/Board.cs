using Mechanics.Composition;
using Mechanics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Entities
{
    public class Board
    {
        private readonly int width;
        private readonly int height;
        private readonly int depth;
        private int _turn { get; set; } = 0;
        public List<ILocatable> Pieces { get; set; } = new List<ILocatable>();
        public Board()
        {
            width = Console.WindowWidth; height = Console.WindowHeight; 
            depth = 10;
        }

        public void DrawScreen()
        {
            for (int x = 1; x < width; x++)
                for (int y = 1; y < height; y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(".");
                }
            foreach (var xy in Pieces.Select(p => (x: p.Location.Value.x, y: p.Location.Value.y)))
            {
                Console.SetCursorPosition(xy.x, xy.y);
                Console.Write("@");
                Console.SetCursorPosition(xy.x, xy.y);
            }
        }

        private void HandleWrapAround(Trip location)
        {
            throw new NotImplementedException();
        }

        public void AddPieces(IEnumerable<ILocatable> pieces)
        {
            foreach (var piece in pieces)
            {
                this.AddPieces(piece);
            }
        }

        public void AddPieces(ILocatable piece)
        {
            this.Pieces.Add(piece);
        }

        public void Tick()
        {
            _turn++;
            this.DrawScreen();
        }
    }

}
