using System;
namespace OOP1Uppgift
{
    public abstract class Shape
    {
        public Point MiddlePoint { get; set; }
        public double Perimeter { get; set; }
        public double Radius { get; set; }
        public double Area { get; set; }
        public string TypeOfShape { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculateRadius();
        public abstract bool HitOrNot(Point input);

        public Shape(double x, double y, double perimeter, string shape)
        {
            MiddlePoint = new Point(x, y);
            Perimeter = perimeter;
            TypeOfShape = shape;
        }
    }
}