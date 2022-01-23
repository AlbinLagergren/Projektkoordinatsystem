using System;
using System.Collections.Generic;
using System.Text;

namespace Projektarbete
{
    public class PointScore
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Score { get; private set; }

        public PointScore(double x, double y)
        {
            X = x;
            Y = y;
            Score = 0;
        }
        public PointScore(double x, double y, double score)
        {
            X = x;
            Y = y;
            Score = score;
        }
    }
}
