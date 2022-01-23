using System;
using System.Collections.Generic;
using System.Text;

namespace Projektarbete
{
    public class Shape : ShapeInformation
    {
        public Shape (double x, double y, double perimeter, string shape)
        {
            MiddlePoint = new PointScore(x, y);
            Perimeter = perimeter;
            TypeOfShape = shape;
        }
    }
}
