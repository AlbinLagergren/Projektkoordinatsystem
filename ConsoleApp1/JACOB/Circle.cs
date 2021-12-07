using System;
using System.Collections.Generic;
using System.Text;
namespace JACOB
{
    class Circle : Shape
    {


        private double Radius;
        double X;
        double Y;
        double Area;
        double Circumference;
        public string Shapename { get; set; }




        public Circle(Vector2 p, double circumference)
        {
            this.Shapename = "CIRCLE";
            X = p.X;
            Y = p.Y;
            Circumference = circumference;
            Radius = circumference / (2 * Math.PI);
            Area = CalcArea();

        }

        public double CalcArea()
        {
            return Math.PI * Radius * Radius;


        }

        public bool Inside(Vector2 p)
        {

            double distanceToCenter = Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
            return distanceToCenter < Radius;

        }


    }

}
