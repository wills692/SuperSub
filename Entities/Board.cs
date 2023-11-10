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
        public List<ILocatable> Pieces { get; set; } = new List<ILocatable>();
        public Board()
        {
            width = Console.BufferWidth; height = Console.BufferHeight; depth = 10;
        }



        public void DrawScreen()
        {
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("X");
                }
            foreach (var xy in Pieces.Select(p => (x: p.Location.Value.x, y: p.Location.Value.y)))
            {
                Console.SetCursorPosition(xy.x, xy.y);
                Console.Write("@");
            }
        }
    }
}
