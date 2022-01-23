using System;
using System.Collections.Generic;
namespace OOP1Uppgift
{
    public class ParseInput
    {

        public List<Point> PointParser(string input)
        {
            List<Point> PointScoreList = new List<Point>();

            string[] arr = input.Trim(';').Replace(" ", "").Split(';');

            try
            {
                foreach (string point in arr)
                {
                    string[] arr2 = point.Split(',');

                   
                    if (double.TryParse(arr2[0], out double x) && double.TryParse(arr2[1], out double y) && double.TryParse(arr2[2], out double score))
                    {
                        Point temp = new Point(x, y, score);
                        PointScoreList.Add(temp);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Your input for the points is incorrect. It should follow this format: X, Y, SCORE. Each point should also be separated with a ‘;’");
            }
            return PointScoreList;
        }
        public List<Shape> ShapeParser(string input)
        {
            List<Shape> ShapeList = new List<Shape>();

            string[] arr = input.Trim(';').Replace(" ", "").Split(';');

            try
            {
                foreach (string point in arr)
                {
                    string[] arr2 = point.Split(',');
                    string shape = arr2[0];
           
                    if (double.TryParse(arr2[1], out double x) && double.TryParse(arr2[2], out double y) && double.TryParse(arr2[3], out double perimeter))
                    {
                        switch (shape)
                        {
                            case "CIRCLE":
                                Circle TempCircle = new Circle(x, y, perimeter, shape);
                                ShapeList.Add(TempCircle);
                                break;
                            case "TRIANGLE":
                                Polygon TempTriangle = new Polygon(x, y, perimeter, 3, shape);
                                ShapeList.Add(TempTriangle);
                                break;
                            case "SQUARE":
                                Polygon TempSquare = new Polygon(x, y, perimeter, 4, shape);
                                ShapeList.Add(TempSquare);
                                break;
                            case "PENTAGON":
                                Polygon TempPentagon = new Polygon(x, y, perimeter, 5, shape);
                                ShapeList.Add(TempPentagon);
                                break;
                            case "HEXAGON":
                                Polygon TempHexagon = new Polygon(x, y, perimeter, 6, shape);
                                ShapeList.Add(TempHexagon);
                                break;
                            case "HEPTAGON":
                                Polygon TempHeptagon = new Polygon(x, y, perimeter, 7, shape);
                                ShapeList.Add(TempHeptagon);
                                break;
                            case "OCTAGON":
                                Polygon TempOctagon = new Polygon(x, y, perimeter, 8, shape);
                                ShapeList.Add(TempOctagon);
                                break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Your input for the shapes is incorrect. It should follow this format: SHAPE, X, Y, PERIMETER. Each point should also be separated with a ‘;’");
            }
            return ShapeList;
        }
        public Dictionary<string, double> ShapeScore(string input)
        {
            Dictionary<string, double> ShapeScoreList = new Dictionary<string, double>();

            string[] arr = input.Trim(';').Replace(" ", "").Split(';');

            try
            {
                foreach (string point in arr)
                {
                    string[] arr2 = point.Trim().Split(',');
                    string shape = arr2[0];


                    if (shape == "CIRCLE" || shape == "TRIANGLE" || shape == "SQUARE" || shape == "PENTAGON" || shape == "HEXAGON" || shape == "HEPTAGON" || shape == "OCTAGON")
                    {
                        if (double.TryParse(arr2[1], out double score))
                        {
                            ShapeScoreList.Add(shape, score);
                            
                        }                       
                    }
                }               
            }
            catch (Exception)
            {
                Console.WriteLine("Your input for the shape scores is incorrect. It should follow this format: SHAPE, SHAPE_SCORE.Each point should also be separated with a ‘;’");
            }
            return ShapeScoreList;
        }
    }
}