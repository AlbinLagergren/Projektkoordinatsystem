using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    class Shape
    {
        public string shapeName = "";
        public int x;
        public int y;
        public int Perimeter;

        class Circle : Shape
        {
            public Circle (string shapeName, int x, int y, int Perimeter)
            {
                this.shapeName = shapeName;
                this.x = x;
                this.y = y;
                this.Perimeter = Perimeter;
            }

        }
        class Square : Shape
        {
            public Square (string shapeName, int x, int y, int Perimeter)
            {
                this.shapeName = shapeName;
                this.x = x;
                this.y = y;
                this.Perimeter = Perimeter;
            }
        }

        static bool inShape(string shapeName, int x, int y)
        {
            if(shapeName == "Circle")
            {
                
            }
        }
    }
}
