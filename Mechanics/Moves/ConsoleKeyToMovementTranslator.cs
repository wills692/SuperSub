using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanics.Moves
{
    public class ConsoleKeyToMovement
    {
        public static (int, int, int) Translate(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    return(0, 1, 0);
                case ConsoleKey.LeftArrow:
                    return (-1, 0, 0);
                case ConsoleKey.RightArrow:
                    return (1, 0, 0);
                case ConsoleKey.DownArrow:
                    return (0, -1, 0);
                default:
                    return(0, 0, 0);
            }
        }
    }
}
