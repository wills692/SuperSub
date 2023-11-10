using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanics.Composition
{
    public interface IMoveable : ILocatable
    {
        void MakeHeading((int x, int y, int z) vector);
    }
}
