using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlopeOfALine
{
    public class Line
    {
        public Point startPoint {  get; private set; }
        public Point endPoint { get; private set; }
        public bool isVertical { get { return endPoint.X - startPoint.X == 0; } }

        public Line (Point start, Point end)
        {
            startPoint = start;
            endPoint = end;
        }

        public double CalculateSlope()
        {
            if (isVertical)
            {
                return 0;
            }

            return (endPoint.Y - startPoint.Y) / (endPoint.X - startPoint.X);
        }
    }
}
