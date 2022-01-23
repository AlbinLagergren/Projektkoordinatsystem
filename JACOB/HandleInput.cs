using System;
using System.Collections.Generic;
using System.Text;
namespace JACOB
{
    class HandleInput
    {

        //public ShapeScore ss { get; private set; }
        public double x1 { get; private set; }

        public double y1 { get; private set; }
        public double pointscore { get; private set; }
        public double pointscore2 { get; private set; }

        public List<PointScore> pointscoreList;
        List<Shape> shapeList;
        Dictionary<string, int> shapeValues;

        public HandleInput(string[] input)
        {
            pointscoreList = readPoints1(input[0].Trim().TrimEnd(';'));
            shapeList = readShapes(input[1].Trim().TrimEnd(';'));
            shapeValues = readShapeScore(input[2].TrimEnd(';'));
        }

        public List<PointScore> readPoints1(string pointstring)
        {
            List<PointScore> outList = new List<PointScore>();

            string[] Sarr = pointstring.Split(';');
            for (int i = 0; i < Sarr.Length; i++)
            {
                string[] point1 = Sarr[i].Split(',');
                if (point1.Length != 3)
                {
                    Console.WriteLine("Your input for the points is incorrect.");
                    Console.WriteLine("It should follow this format: X, Y, SCORE.");
                    Console.WriteLine("Each point should also be separated with a ‘;’");

                    Environment.Exit(0);
                }

                Vector2 vector2 = null;
                PointScore pointScore = null;

                try
                {
                    vector2 = new Vector2(int.Parse(point1[0]), int.Parse(point1[1]));
                    pointScore = new PointScore(vector2, int.Parse(point1[2]));
                }
                catch
                {
                    Console.WriteLine("Your input for the points is incorrect.");
                    Console.WriteLine("It should follow this format: X, Y, SCORE.");
                    Console.WriteLine("Each point should also be separated with a ‘;’");

                    Environment.Exit(0);
                }

                outList.Add(pointScore);

            }
            return outList;
        }

        public List<Shape> readShapes(string shapestring)
        {
            List<Shape> outList = new List<Shape>();

            shapestring.Trim();
            string[] Sarr = shapestring.Split(';');


            for (int i = 0; i < Sarr.Length; i++)
            {
                outList.Add(readShape(Sarr[i]));
            }
            return outList;
        }

        public Shape readShape(string shape)
        {
            shape = shape.Replace(" ", string.Empty);
            string[] shapeArr = shape.Split(',');
            int circumference = 0;
            Vector2 vector = null;

            try
            {
                circumference = int.Parse(shapeArr[3]);
                vector = new Vector2(int.Parse(shapeArr[1]), int.Parse(shapeArr[2]));
            }
            catch
            {
                Console.WriteLine("Your input for the shapes is incorrect");
                Console.WriteLine("It should follow this format: SHAPE, X, Y, PERIMETER");
                Console.WriteLine("Each point schould also be separated with a ';' ");

                Environment.Exit(0);

            }

            switch (shapeArr[0].ToUpper())
            {
                case "CIRCLE":
                    Circle circle = new Circle(vector, circumference);
                    //ss = new ShapeScore(circle, shapeValues["CIRCLE"]);
                    return circle;

                case "TRIANGLE":
                    Polygon polygonTri = new Polygon(vector, circumference, 3, shapeArr[0].ToUpper());
                    //ss = new ShapeScore(polygonTri, shapeValues["TRIANGLE"]);
                    return polygonTri;

                case "SQUARE":
                    Polygon polygonSQA = new Polygon(vector, circumference, 4, shapeArr[0].ToUpper());
                    //ss = new ShapeScore(polygonSQA, shapeValues["SQUARE"]);
                    return polygonSQA;

                case "PENTAGON":
                    Polygon polygonPen = new Polygon(vector, circumference, 5, shapeArr[0].ToUpper());
                    //ss = new ShapeScore(polygonPen, shapeValues["PENTAGON"]);
                    return polygonPen;

                case "HEXAGON":
                    Polygon polygonHex = new Polygon(vector, circumference, 6, shapeArr[0].ToUpper());
                    //ss = new ShapeScore(polygonHex, shapeValues["HEXAGON"]);
                    return polygonHex;

                case "HEPTAGON":
                    Polygon polygonHEP = new Polygon(vector, circumference, 7, shapeArr[0].ToUpper());
                    //ss = new ShapeScore(polygonHEP, shapeValues["HEPTAGON"]);
                    return polygonHEP;

                case "OCTAGON":
                    Polygon polygonOct = new Polygon(vector, circumference, 8, shapeArr[0].ToUpper());
                    // ss = new ShapeScore(polygonOct, shapeValues["OCTAGON"]);
                    return polygonOct;

                default:
                    Console.WriteLine($"The shape{shapeArr[0].ToUpper()} doesn't exist");
                    Environment.Exit(0);
                    return null;
            }
        }

        public Dictionary<string, int> readShapeScore(string shapestring)
        {
            Dictionary<string, int> outdic = new Dictionary<string, int>();
            string[] ShapeScoreArr = shapestring.Trim().TrimEnd(';').Split(';');

            for (int i = 0; i < ShapeScoreArr.Length; i++)
            {
                string[] shapescore1 = ShapeScoreArr[i].Split(',');
                try
                {
                    outdic.Add(shapescore1[0].ToUpper(), int.Parse(shapescore1[1]));
                }
                catch
                {
                    Console.WriteLine("Your input for the shape scores is incorrect.");
                    Console.WriteLine("It should follow this format: SHAPE, SHAPE_SCORE.");

                    Environment.Exit(0);
                }


            }
            return outdic;
        }

        public int Start()
        {
            double rounded = 0;
            int result = 0;
            for (int i = 0; i < pointscoreList.Count; i++)
            {
                for (int j = 0; j < shapeList.Count; j++)
                {
                    string shapetype = shapeList[j].Shapename;
                    int shapescore = shapeValues[shapetype];
                    if (shapeList[j].Inside(pointscoreList[i].V))
                    {
                        rounded += (shapeList[j].CalcArea() + shapescore + pointscoreList[i].Score);
                        result = (int)Math.Ceiling(rounded);
                    }
                    else
                    {
                        rounded += (shapeList[j].CalcArea() + shapescore) / 4;
                        result = (int)Math.Ceiling(rounded);
                    }
                }
            }
            return result;
        }

    }
}
