//using Mechanics.Composition;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Mechanics
//{
//    public class Cube
//    {
//        public readonly Mechanics.Trip Position;
//        public HashSet<ILocatable> Pieces { get; set; } = new HashSet<ILocatable>();    

//        public Cube((int x, int y, int z) trip)
//        {
//            this.Position = new Trip(trip);
//        }

//        public void ShowTile()
//        {
//            Console.SetCursorPosition(Position.Value.x, Position.Value.y);
//            switch(Pieces.Count())
//            {
//                case 0:
//                    Console.Write("X");
//                    break;
//                default:
//                    Console.Write(Pieces.Count.ToString()); 
//                    break;
//            }
//        }


//    }
//}
