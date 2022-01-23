using System;
using System.Collections.Generic;
using System.Text;

namespace Projektarbete
{
    class Circle : Shape 
    {
        public Circle(double x, double y, double perimeter, string shape) : base(x, y, perimeter, shape)
        {
            TypeOfShape = shape;
        }

        public double CalculateRadius()
        {
            Radius = CalculateRadius();

            return Perimeter / (Math.PI * 2);
        }

        public double CalculateArea()
        {
            Area = CalculateArea();
            return (Radius * Radius) * Math.PI;
        }
        public bool HitOrMiss(PointScore input)
        {
            double XCoordinate = input.X - MiddlePoint.X;
            double YCoordinate = input.Y - MiddlePoint.Y;

            double distanceToCenter = Math.Sqrt(Math.Pow(XCoordinate, 2) + Math.Pow(YCoordinate, 2));
                return distanceToCenter <= Radius * Radius;
          
        }
    }
}
