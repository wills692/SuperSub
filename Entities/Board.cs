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
        //Cube[,,] Cells = new Cube[8, 8, 8];
        List<Cube> Cells = new List<Cube>();

        public Board()
        {
            this.InitializeCells();
        }

        void InitializeCells()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    for (int k = 0; k < 8; k++)
                    {
                        var c = new Cube((i, j, k));
                        Cells.Add(c);
                    }

        }
        public void PlacePiece(IEnumerable<ILocatable> pieces)
        {
            foreach (var p in pieces)
                PlacePiece(p);
        }
        public void PlacePiece(ILocatable piece)
        {
            this.Cells.FirstOrDefault(c => c.Position.Value == piece.Value)?.Pieces.Add(piece);
        }

        public void NextTurn()
        {
            //this.Cells.ForEach(c => c.ShowTile());
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    Cells.Where(c => c.Position.Value.x == i && c.Position.Value.y == j).OrderByDescending(x => x.Pieces.Count).First().ShowTile();
        }
    }
}
