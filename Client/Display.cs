using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Display
    {
        public static void ShowTiles()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write("X");
                }
        }
    }
}
