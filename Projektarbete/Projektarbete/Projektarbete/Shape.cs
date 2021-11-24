using System;
using System.Collections.Generic;
using System.Text;

namespace Projektarbete
{
    class Shape
    {
        
        public int x { get; set; }
        public int y { get; set; }
        public int Perimeter { get; set; }
        public string shapeName { get; set; }

        public Shape (string shapeName, int x, int y, int Perimeter)
        {
            this.shapeName = shapeName;
            this.x = x;
            this.y = y;
            this.Perimeter = Perimeter;
        }
        class Circle : Shape
        {
            public Circle(string shapeName, int x, int y, int Perimeter) : base (shapeName, x, y, Perimeter)
            {
                this.shapeName = shapeName;
                this.x = x;
                this.y = y;
                this.Perimeter = Perimeter;
            }

        }
        class Square : Shape
        {
            public Square(string shapeName, int x, int y, int Perimeter) : base(shapeName, x, y, Perimeter)
            {
                this.shapeName = shapeName;
                this.x = x;
                this.y = y;
                this.Perimeter = Perimeter;
            }
        }
        class Triangle : Shape
        {            
            public Triangle(string shapeName, int x, int y, int Perimeter) : base(shapeName, x, y, Perimeter)
            {
                this.shapeName = shapeName;
                this.x = x;
                this.y = y;
                this.Perimeter = Perimeter;
            }
        }

        class Pentagon : Shape
        {
            public Pentagon(string shapeName, int x, int y, int Perimeter) : base(shapeName, x, y, Perimeter)
            {
                this.shapeName = shapeName;
                this.x = x;
                this.y = y;
                this.Perimeter = Perimeter;
            }
        }
        
        class Hexagon : Shape
        {
            public Hexagon(string shapeName, int x, int y, int Perimeter) : base(shapeName, x, y, Perimeter)
            {
                this.shapeName = shapeName;
                this.x = x;
                this.y = y;
                this.Perimeter = Perimeter;
            }
        }
        class Heptagon : Shape
        {
            public Heptagon(string shapeName, int x, int y, int Perimeter) : base(shapeName, x, y, Perimeter)
            {
                this.shapeName = shapeName;
                this.x = x;
                this.y = y;
                this.Perimeter = Perimeter;
            }

        }
        class Octagon : Shape
        {
            public Octagon(string shapeName, int x, int y, int Perimeter) : base(shapeName, x, y, Perimeter)
            {
                this.shapeName = shapeName;
                this.x = x;
                this.y = y;
                this.Perimeter = Perimeter;
            }
        }

        /*static bool inShape(string shapeName, int x, int y)
        {
            if (shapeName == "Circle")
            {

            }
        }*/
    }
}
