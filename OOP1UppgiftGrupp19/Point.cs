using System;
namespace OOP1Uppgift
{
    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Score { get; private set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
            Score = 0;
        }
        public Point(double x, double y, double score)
        {
            X = x;
            Y = y;
            Score = score;
        }
    }
}