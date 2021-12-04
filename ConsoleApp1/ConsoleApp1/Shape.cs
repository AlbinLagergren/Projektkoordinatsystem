using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Shape
    {
        public int x { get; set; }
        public int y { get; set; }

        public double area { get; set; }

        public int sideAmount { get; set; }

        public bool HitOrMiss(Point x);

        public double GetArea();

    }
}
