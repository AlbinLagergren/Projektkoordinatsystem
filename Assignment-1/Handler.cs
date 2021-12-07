using System;
namespace Assignment
{
    internal class Handler
    {
        public void runProgram(string[] args) 
        {
            Helper helper = new Helper();
            string[]? output;
            try
            {
                // If there is some arguments issue then it will throw error.
                if (args.Length < 3 || args.Length > 3)
                {
                    throw new ArgumentException("Please enter valid arguments.");
                }
                // Initial it will normalize the first argument.
                output = helper.normalizeInput(args[0]);
                if (output != null)
                {
                    PointScore[] pointScores = new PointScore[output.Length];
                    // Set All pointScores to its object
                    for (int i = 0; i < pointScores.Length; i++)
                    {
                        string[] coordinates = output[i].Split(",");
                        pointScores[i] = new PointScore(Int16.Parse(coordinates[0]), Int16.Parse(coordinates[1]));
                    }
                    // Then it will normalize the second argument.
                    output = helper.normalizeInput(args[1]);
                    if (output != null)
                    {
                        // Set All shapes to its object
                        Shape[] shapes = new Shape[output.Length];
                        for (int i = 0; i < shapes.Length; i++)
                        {
                            string[] shape = output[i].Split(",");
                            int sides = 0;
                            // According to the given shape it will create Object and initilize parameters
                            switch (shape[0])
                            {
                                case nameof(Helper.Shapes.CIRCLE):
                                    shapes[i] = new Circle(Int16.Parse(shape[1]), Int16.Parse(shape[2]), Int16.Parse(shape[3]));
                                    break;
                                case nameof(Helper.Shapes.TRIANGLE):
                                    sides = 3;
                                    break;
                                case nameof(Helper.Shapes.SQUARE):
                                    sides = 4;
                                    break;
                                case nameof(Helper.Shapes.PENTAGON):
                                    sides = 5;
                                    break;
                                case nameof(Helper.Shapes.HEXAGON):
                                    sides = 6;
                                    break;
                                case nameof(Helper.Shapes.HEPTAGON):
                                    sides = 7;
                                    break;
                                case nameof(Helper.Shapes.OCTAGON):
                                    sides = 8;
                                    break;
                                default: break;
                            }
                            if (sides != 0)
                            {
                                shapes[i] = new Polygon(Int16.Parse(shape[1]), Int16.Parse(shape[2]), Int16.Parse(shape[3]), sides);
                            }
                        }
                        // Then it will normalize the third argument.
                        output = helper.normalizeInput(args[2]);
                        if (output != null)
                        {
                            // Set All shape scores to its object
                            ShapeScore[] shapesScores = new ShapeScore[output.Length];
                            for (int i = 0; i < shapesScores.Length; i++)
                            {
                                string[] shapesScore = output[i].Split(",");
                                shapesScores[i] = new ShapeScore(Int16.Parse(shapesScore[1]), shapesScore[0]);
                            }
                            //Now we have all points and Shapes and ShapeScores, so calculate hit and miss
                            float totalScore = 0;
                            for (int i = 0; i < pointScores.Length; i++)
                            {
                                for (int j = 0; j < shapes.Length; j++)
                                {
                                    string result = shapes[j].hitOrMiss(pointScores[i]);
                                    totalScore += helper.getTotalShapeScores(shapesScores) + helper.getTotalPointScores(pointScores);
                                    // After calculating hit and miss and get value of total Score we will get the total Value.
                                    if (result == "Miss")
                                    {
                                        totalScore += totalScore / 4;
                                    }
                                }
                            }
                            // Then the final result will be printed on Console.
                            Console.Write(Math.Floor(totalScore));
                        }
                        else
                        {
                            throw new Exception("ShapScore is not validated.");
                        }
                    }
                    else
                    {
                        throw new Exception("Shapes are not validated.");
                    }
                }
                else
                {
                    throw new Exception("PointScore is not validated.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
