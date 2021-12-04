using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Polygon : Shape
    {
        // private int sides;
        public int sideAmount { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public double area { get; set; }
        public int sideLength;
        public int perimeter;
        public double radius;

        
        public Polygon(int x, int y, int perimeter, int sideAmount)
        {
            this.x = x;
            this.y = y;
            this.sideAmount = sideAmount;
            this.perimeter = perimeter;
            
            sideLength = perimeter / sideAmount;
        }
        public Polygon() // ctor overloading
        {

        }
        
        public double GetRadius() //räknar ut och hämtar radien
        {
            radius = perimeter / sideAmount / (2 * Math.Sin(Math.PI / Convert.ToDouble(sideAmount)));
            return radius;
        }
        public Point[] CornerCoordinates(Point j) //räknar ut hörnen för formen
        {
            Point[] Vertices = new Point[sideAmount];
            double angle;
            double offset;

            angle = ((Math.PI * 2) / sideAmount);
            if (sideAmount % 2 == 0)
            {
                offset = angle / 2;
            }
            else
            {
                offset = 0;
            }
            for (int i = 0; i < sideAmount; i++)
            {
                double xCord =  j.getxCord() + GetRadius() * Math.Sin(i * angle + offset);
                double yCord = j.getyCord() + GetRadius() * Math.Cos(i * angle + offset);
                Vertices[i] = new Point(xCord, yCord);
            }
            return Vertices;
        }
            
        public double GetArea() //räknar ut arean för polygonerna
        {
            if (sideAmount == 3)
            {
                double sideLength = perimeter / 3;
                double height = Math.Sqrt((sideLength * sideLength) - ((sideLength / 2) * (sideLength / 2)));
                area = ((sideLength / 2) * height);
            }
            else if (sideAmount == 4)
            {
                area = (sideLength * sideLength);
            }
            else
            {
                area = (sideAmount * sideLength / (2 * Math.Tan(Math.PI / 180) * 180 / Convert.ToDouble(sideAmount)) / 2);
            }
            return area;
        }
        public bool HitOrMiss(Point s) //kollar om pekaren träffar elr inte
        {
            Point[] Vertices = new Point[sideAmount];
            int j = Vertices.Length - 1;
            bool isHit = false;
            for (int i = 0; i < Vertices.Length; i++)
            {
                if (Vertices[i].getY() < s.getY() && Vertices[j].getY() >= s.getY() || Vertices[j].getY() < s.getY() && Vertices[i].getY() >= s.getY())
                {
                    if (Vertices[i].getX() + (s.getY() - Vertices[i].getY() / (Vertices[j].getY() - Vertices[i].getY()) * (Vertices[j].getX() - Vertices[i].getX())) < s.getX())
                    {
                        isHit = !isHit;
                    }
                }
                j = i;
            }
            return isHit;
        }
    }
}
