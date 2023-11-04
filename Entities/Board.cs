using Mechanics.Composition;
using Mechanics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        Cells.Add(new Cube((i, j, k)));

        }

        public void PlacePiece(ILocatable locatable)
        {
            this.Cells.FirstOrDefault(c => c.Position.Trip == locatable.Trip)?.Pieces.Add(locatable);
        }

        public void Show()
        {

        }
    }
}
