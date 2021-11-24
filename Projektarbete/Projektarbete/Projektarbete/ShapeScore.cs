using System;
using System.Collections.Generic;
using System.Text;

namespace Projektarbete
{
    class ShapeScore : Shape
    {
        public int shapePoints;


        public ShapeScore (string shapeName, int shapePoints)
        {
            this.shapeName = shapeName;
            this.shapePoints = shapePoints;
        }

    }
}
