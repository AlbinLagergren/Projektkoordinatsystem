using System;
namespace Pakistan
{
    class Helper
    {
        public enum shapes
        {
            CIRCLE,
            TRIANGLE,
            SQUARE,
            PENTAGON,
            HEXAGON,
            HEPTAGON,
            OCTAGON
        }
        public double calculateDistance(int X1, int X2, int Y1, int Y2)
        {
            double left = (X2 - X1) * (X2 - X1);
            double right = (Y2 - Y1) * (Y2 - Y1);
            double total = left + right;
            return Math.Sqrt(total);
        }
        public string[]? normalizeInput(string input)
        {
            string[] inputs = { "" };
            try
            {
                inputs = input.Split(";");
                // To pop last element if it has ";"
                if (inputs[inputs.Length - 1] == "")
                {
                    inputs = inputs.Where(w => w != inputs[2]).ToArray();
                }
                return inputs;
            }
            catch
            {
                return null;
            }
        }
        public int getTotalShapeScores(ShapeScore[] shapeScores)
        {
            int total = 0;
            foreach (ShapeScore shapeScore in shapeScores)
            {
                total += shapeScore.getScore();
            }
            return total;
        }
        public int getTotalPointScores(PointScore[] pointScores)
        {
            int total = 0;
            foreach (PointScore pointScore in pointScores)
            {
                total += pointScore.getX() + pointScore.getY();
            }
            return total;
        }
    }
}
