using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt2
{

    public abstract class Shape
    {
        public PointScore MiddlePoint { get; set; }
        public double Perimeter { get; set; }
        public double Radius { get; set; }
        public double Area { get; set; }
        public string TypeOfShape { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculateRadius();
        public abstract bool HitOrNot(PointScore input);

        public Shape(double x, double y, double perimeter, string shape)
        {
            MiddlePoint = new PointScore(x, y);
            Perimeter = perimeter;
            TypeOfShape = shape;
        }
    }

}
