using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controls
{
    internal class Keyboard
    {
        public static ICollection<ConsoleKey> MovementKeys { get; } = new List<ConsoleKey> { ConsoleKey.DownArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow, ConsoleKey.UpArrow };

        static Keyboard()
        {

        }

        public static T GetMove<T>(Func<ConsoleKey, T> KeyToMoveTranslator) where T : struct
        {
            var q = Console.ReadKey(true).Key;
            while (!MovementKeys.Contains(q)) { q = Console.ReadKey(true).Key; };
            return KeyToMoveTranslator(q);
        }

        public T MyGenericFunction<T>(ConsoleKey key) where T : struct, INullable
        {
            // function body
            return default(T);
        }

    }
}
