using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Coordinate
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Coordinate)
            {
                Coordinate other = (Coordinate)obj;
                
                return other.X == X && other.Y == Y;
            }

            return false;
        }
    }
}
