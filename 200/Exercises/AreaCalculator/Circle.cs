using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Circle
    {
        public double GetArea(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
