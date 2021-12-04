using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class InputClass
    {
        public double TotalScore = 0;
        public double CircleScore;
        public double TriangleScore;
        public double SquareScore;
        public double PentagonScore;
        public double HexagonScore;
        public double HeptagonScore;
        public double OctagonScore;

        List<Point> lista = new List<Point>(); //Lista för punkterna
        List<Shape> listOfShapes = new List<Shape>(); //Lista som innehåller "shapes"
        Dictionary<string, int> dictShapeScore = new Dictionary<string, int>(); //shape(key) och poäng

        Helper helper = new Helper();
        public void PrintScore()
        {
            Console.WriteLine(Convert.ToInt32(Math.Round(TotalScore)));
        }

        public void ApplyArguments(string[] _args)
        {
            try
            {
                string[] Cord1 = helper.normalizeInput(_args[0]);

                for (int i = 0; i < Cord1.Length; i++)
                {
                    if (Cord1[i] == "")
                    {

                    }
                    else
                    {
                        string[] Input1 = Cord1[i].Split(',');

                        Point d = new Point(Convert.ToInt32(Input1[0]), Convert.ToInt32(Input1[1]), Convert.ToInt32(Input1[2]));
                        AddCord(d);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input. Please try again.");
                throw;
            }

            try
            {
                string[] Cord2 = helper.normalizeInput(_args[1]);

                for (int i = 0; i < Cord2.Length; i++)
                {
                    if (Cord2[i] == "")
                    {

                    }
                    else
                    {
                        string[] Input2 = Cord2[i].Split(',');

                        if (Input2[0] == nameof(Helper.shapes.CIRCLE))
                        {
                            Circle circle = new Circle(Convert.ToInt32(Input2[1]), Convert.ToInt32(Input2[2]), Convert.ToInt32(Input2[3]));
                            AddShape(circle);
                        }
                        else if (Input2[0] == nameof(Helper.shapes.TRIANGLE))
                        {
                            Polygon triangle = new Polygon(Convert.ToInt32(Input2[1]), Convert.ToInt32(Input2[2]), Convert.ToInt32(Input2[3]), 3);
                            AddShape(triangle);
                        }
                        else if (Input2[0] == nameof(Helper.shapes.SQUARE))
                        {
                            Polygon square = new Polygon(Convert.ToInt32(Input2[1]), Convert.ToInt32(Input2[2]), Convert.ToInt32(Input2[3]), 4);
                            AddShape(square);
                        }
                        else if (Input2[0] == nameof(Helper.shapes.HEPTAGON))
                        {
                            Polygon heptagon = new Polygon(Convert.ToInt32(Input2[1]), Convert.ToInt32(Input2[2]), Convert.ToInt32(Input2[3]), 5);
                            AddShape(heptagon);
                        }
                        else if (Input2[0] == nameof(Helper.shapes.HEXAGON))
                        {
                            Polygon hexagon = new Polygon(Convert.ToInt32(Input2[1]), Convert.ToInt32(Input2[2]), Convert.ToInt32(Input2[3]), 6);
                            AddShape(hexagon);
                        }
                        else if (Input2[0] == nameof(Helper.shapes.HEPTAGON))
                        {
                            Polygon heptagon = new Polygon(Convert.ToInt32(Input2[1]), Convert.ToInt32(Input2[2]), Convert.ToInt32(Input2[3]), 7);
                            AddShape(heptagon);
                        }
                        else if (Input2[0] == nameof(Helper.shapes.OCTAGON))
                        {
                            Polygon octagon = new Polygon(Convert.ToInt32(Input2[1]), Convert.ToInt32(Input2[2]), Convert.ToInt32(Input2[3]), 8);
                            AddShape(octagon);
                        }
                    }
                }
            }
            catch (Exception)
            {
            Console.WriteLine("Incorrect input. Please try again.");
            throw;
            }

            try
            {
                string[] Cord3 = helper.normalizeInput(_args[2]);
                for (int i = 0; i < Cord3.Length; i++)
                {
                    if (Cord3[i] == "")
                    {

                    }
                    else
                    {
                        string[] Input3 = Cord3[i].Split(',');
                        int.TryParse(Cord3[1], out int shapeScore);

                        switch (Cord3[0])
                        {
                            case nameof(Helper.shapes.CIRCLE):
                                dictShapeScore.Add(Cord3[0], shapeScore);
                                CircleScore = dictShapeScore[nameof(Helper.shapes.CIRCLE)];
                                break;

                            case nameof(Helper.shapes.TRIANGLE):
                                dictShapeScore.Add(Cord3[0], shapeScore);
                                TriangleScore = dictShapeScore[nameof(Helper.shapes.TRIANGLE)];
                                break;

                            case nameof(Helper.shapes.SQUARE):
                                dictShapeScore.Add(Cord3[0], shapeScore);
                                SquareScore = dictShapeScore[nameof(Helper.shapes.SQUARE)];
                                break;

                            case nameof(Helper.shapes.PENTAGON):
                                dictShapeScore.Add(Cord3[0], shapeScore);
                                PentagonScore = dictShapeScore[nameof(Helper.shapes.PENTAGON)];
                                break;

                            case nameof(Helper.shapes.HEXAGON):
                                dictShapeScore.Add(Cord3[0], shapeScore);
                                HexagonScore = dictShapeScore[nameof(Helper.shapes.HEXAGON)];
                                break;

                            case nameof(Helper.shapes.HEPTAGON):
                                dictShapeScore.Add(Cord3[0], shapeScore);
                                HeptagonScore = dictShapeScore[nameof(Helper.shapes.HEPTAGON)];
                                break;

                            case nameof(Helper.shapes.OCTAGON):
                                dictShapeScore.Add(Cord3[0], shapeScore);
                                OctagonScore = dictShapeScore[nameof(Helper.shapes.OCTAGON)];
                                break;

                            default:
                                break;
                        }
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input. Please try again.");
                throw;
            }
        }

        public void TotalSC()
        {
            foreach (Point dot in lista)
            {
                foreach (Shape shape in listOfShapes)
                {
                    if (shape.HitOrMiss(dot))
                    {

                    }
                    else if (shape.sideAmount < 3)
                    {
                        TotalScore += (shape.GetArea() + CircleScore + dot.pointScore);
                    }
                    else if (shape.sideAmount == 3)
                    {
                        TotalScore += (shape.GetArea() + TriangleScore + dot.pointScore);
                    }
                    else if (shape.sideAmount == 4)
                    {
                        TotalScore += (shape.GetArea() + SquareScore + dot.pointScore);
                    }
                    else if (shape.sideAmount == 5)
                    {
                        TotalScore += (shape.GetArea() + PentagonScore + dot.pointScore);
                    }
                    else if (shape.sideAmount == 6)
                    {
                        TotalScore += (shape.GetArea() + HexagonScore + dot.pointScore);
                    }
                    else if (shape.sideAmount == 7)
                    {
                        TotalScore += (shape.GetArea() + HeptagonScore + dot.pointScore);
                    }
                    else if (shape.sideAmount == 8)
                    {
                        TotalScore += (shape.GetArea() + OctagonScore + dot.pointScore);
                    }
                    else
                    {
                        if (shape.sideAmount < 3)
                        {
                            TotalScore += (shape.GetArea() + CircleScore / 4);
                        }
                        else if (shape.sideAmount == 3)
                        {
                            TotalScore += (shape.GetArea() + TriangleScore / 4);
                        }
                        else if (shape.sideAmount == 4)
                        {
                            TotalScore += (shape.GetArea() + SquareScore / 4);
                        }
                        else if (shape.sideAmount == 5)
                        {
                            TotalScore += (shape.GetArea() + PentagonScore / 4);
                        }
                        else if (shape.sideAmount == 6)
                        {
                            TotalScore += (shape.GetArea() + HexagonScore / 4);
                        }
                        else if (shape.sideAmount == 7)
                        {
                            TotalScore += (shape.GetArea() + HeptagonScore / 4);
                        }
                        else if (shape.sideAmount == 8)
                        {
                            TotalScore += (shape.GetArea() + OctagonScore / 4);
                        }

                    }
                } 
            }
        }

        public void AddCord(Point s)
        {
            lista.Add(s);
        }

        public void AddShape(Shape shape)
        {
            listOfShapes.Add(shape);
        }

    }
}
