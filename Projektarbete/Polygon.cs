using System;
using System.Collections.Generic;
using System.Text;

namespace Projektarbete
{
    class Polygon : Shape
    {
        private PointScore[] Verticies;
        public int Sides { get; private set; }
        public double SideLength { get; private set; }

        public Polygon(double x, double y, double perimeter, int sides, string shape) : base(x, y, perimeter, shape)
        {
            Sides = sides;
            SideLength = Perimeter / Sides;
            Verticies = CalculateVerticies(x, y, perimeter, sides);
        }
        public double CalculateRadius()
        {
            Radius = CalculateRadius();
            return SideLength / (2 * Math.Sin(Math.PI / Sides));
        }
        public double CalculateArea()
        {
            Area = CalculateArea();

            double area = 0;

            int j = Verticies.Length - 1;
            for (int i = 0; i < Verticies.Length; i++)
            {
                area += (double)(Verticies[j].X + Verticies[i].X) * (Verticies[j].Y - Verticies[i].Y);
                j = i;
            }


            double result = Math.Abs(area / 2);
            return result;
        }
        public PointScore[] CalculateVerticies(double x, double y, double circumference, int sides)
        {
            double offset;
            double sidelength = circumference / sides;
            double circumradius = (sidelength / 2) * Math.Cos(Math.PI / sides) / (Math.Sin(Math.PI / sides));
            PointScore centrepoint = new PointScore(x, y);

            double angle = (Math.PI * 2) / sides;

            if (sides % 2 == 0)

                offset = angle / 2;
            else
                offset = 0;
            double innerAngle = ((sides - 2) * Math.PI) / sides;
            double radius = (sidelength / 2) / Math.Cos(innerAngle / 2);



            PointScore[] vertices = new PointScore[sides];
            for (int i = 0; i < sides; i++)
            {
                //double a = (centrepoint.X + circumradius * Math.Sin(i * angle + offset)); // räkna ut circumradius
                //double b = (centrepoint.Y + circumradius * Math.Cos(i * angle + offset)); // räkna ut circumradius
                double a = (centrepoint.X + radius * Math.Sin(i * angle + offset));
                double b = (centrepoint.Y + radius * Math.Cos(i * angle + offset));
                vertices[i] = new PointScore(a, b);
            }
            return vertices;
        }
        public bool Inside(PointScore p)
        {
            bool inside = false;
            int j = Verticies.Length - 1;

            for (int i = 0; i < Verticies.Length; i++)
            {
                if (Verticies[i].Y < p.Y && (Verticies[j].Y >= p.Y) || Verticies[j].Y < p.Y && Verticies[i].Y >= p.Y)
                {
                    if (Verticies[i].X + (p.Y - Verticies[i].Y) / (Verticies[j].Y - Verticies[i].Y) * (Verticies[j].X - Verticies[i].X) < p.X)
                    {
                        inside = !inside;
                    }
                }
                j = i;
            }
            return inside;
        }
    }
}
