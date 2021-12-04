using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Circle : Shape
    {
        // private int sides;
        public int sideAmount { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public double area { get; set; }
        // public int sideLength;
        public int perimeter;
        public double radius;
        public Circle(int x, int y, int perimeter)
        {
            this.x = x;
            this.y = y;
            this.perimeter = perimeter;
            radius = perimeter / Math.PI / 2;
            area = (Math.Pow(radius, 2) * Math.PI);
        }
        public Circle()    //tom ctro för att kunna skapa objekt med olika antal parametrar.
        {

        }

        public double GetArea()
        {
            return area;
        }
        public bool HitOrMiss(Point c)
        {
            if (((c.getX() - x) * (c.getX() - x)) + ((c.getY() - y) * (c.getY() - y)) <= (radius * radius))
            {
                return true;
            }
            return false;

        }
       
    }
    
}
