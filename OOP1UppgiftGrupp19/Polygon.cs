using System;
using System.Collections.Generic;

namespace OOP1Uppgift
{
    class Polygon : Shape
    {
        public double Sides { get; private set; }
        public double SideLength { get; private set; }
        private List<Point> CornerList;

        public Polygon(double x, double y, double perimeter, double sides, string shape) : base(x, y, perimeter, shape)
        {
            Sides = sides;
            SideLength = Perimeter / Sides;
            Radius = CalculateRadius();
            Area = CalculateArea();
            CornerList = EvenOrOddCoordinates();
        }
        public override double CalculateRadius()
        {
            return SideLength / (2 * Math.Sin(Math.PI / Sides));
        }
        public override double CalculateArea()
        {
            double Apothem = SideLength / (2 * Math.Tan(Math.PI / Sides));
            return (Apothem * Perimeter) / 2;
        }
        public List<Point> EvenOrOddCoordinates()
        {
            double Offset = 0;

            double Angle = (Math.PI * 2) / Sides;

            if (Sides % 2 == 0)
            {
                Offset = (Angle / 2);
            }
            else
            {
                Offset = 0;
            }
            CornerList = new List<Point>();

            for (double i = 0; i < Sides; i++)
            {
                double X = MiddlePoint.X + (Radius * Math.Sin(i * Angle + Offset));
                double Y = MiddlePoint.Y + (Radius * Math.Cos(i * Angle + Offset));
                Point p = new Point(X, Y);

                CornerList.Add(p);
            }
            return CornerList;
        }
        public override bool HitOrNot(Point input)
        {
            int j = CornerList.Count - 1;
            bool IsHit = false;

            for (int i = 0; i < CornerList.Count; i++)
            {
                if (CornerList[i].Y < input.Y && CornerList[j].Y >= input.Y || CornerList[j].Y < input.Y && CornerList[i].Y >= input.Y)
                {
                    if (CornerList[i].X + (input.Y - CornerList[i].Y) / (CornerList[j].Y - CornerList[i].Y) * (CornerList[j].X - CornerList[i].X) < input.X)
                    {
                        IsHit = !IsHit;
                    }
                }
                j = i;
            }
            return IsHit;
        }
    }
}