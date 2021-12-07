using System;
using System.Collections.Generic;
using System.Text;
namespace JACOB
{
    public class ShapeScore
    {
        public double Score;
        public Shape Shape;
        public PointScore point;

        public ShapeScore(Shape shape, double score)
        {

            this.Shape = shape;
            this.Score = score;
        }
    }
}
