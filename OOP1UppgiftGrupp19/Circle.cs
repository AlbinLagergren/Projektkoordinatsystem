using System;
namespace OOP1Uppgift
{
    class Circle : Shape
    {
        public Circle(double x, double y, double perimeter, string shape) : base(x, y, perimeter, shape)
        {
            Radius = CalculateRadius();
            Area = CalculateArea();
            TypeOfShape = shape;
        }
        public override double CalculateRadius()
        {
            return Perimeter / (Math.PI * 2);
        }
        public override double CalculateArea()
        {
            return (Radius * Radius) * Math.PI;
        }
        public override bool HitOrNot(Point input)
        {
            double XCoordinate = input.X - MiddlePoint.X;
            double YCoordinate = input.Y - MiddlePoint.Y;

            if (Math.Pow(XCoordinate, 2) + Math.Pow(YCoordinate, 2) <= Radius * Radius)
                return true;
            else
                return false;
        }
    }
}
