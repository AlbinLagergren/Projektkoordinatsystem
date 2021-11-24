using System;
using System.Collections.Generic;
using System.Text;

namespace Projektarbete
{
   
    public class coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        


    }

    public class Circle : coordinate
    {
        public int perimeter;

        public Circle(int X, int Y, int perimeter)
        {
            this.X = X;
            this.Y = Y;
            this.perimeter = perimeter;

        }

    }

    public class Square : coordinate
    {
        int length;
        public Square(int X, int Y, int length)
        {
            this.length = length;
            this.X = X;
            this.Y = Y;
        }

    }
}


