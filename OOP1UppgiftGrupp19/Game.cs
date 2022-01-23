using System;
using System.Collections.Generic;
namespace OOP1Uppgift
{
    public class Game
    {
        public List<Point> PointList = new List<Point>();
        public List<Shape> ShapeList = new List<Shape>();
        public Dictionary<string, double> PointsShapeList = new Dictionary<string, double>();

        public Game(string[] inputlist, ParseInput input)
        {
            PointList = input.PointParser(inputlist[0]);
            ShapeList = input.ShapeParser(inputlist[1]);
            PointsShapeList = input.ShapeScore(inputlist[2]);
        }
        public double ScoreCalculation()
        {
            double sum = 0;
            double total = 0;

            foreach (var point in PointList)
            {
                foreach (var shape in ShapeList)
                {
                    if (shape.HitOrNot(point))
                    {
                        sum = shape.Area * PointsShapeList[shape.TypeOfShape] * point.Score;
                        total += sum;
                    }
                    else
                    {
                        sum = (shape.Area * PointsShapeList[shape.TypeOfShape]) / 4;
                        total += sum;
                    }
                }
            }
            return Math.Round(total);
        }
    }
}