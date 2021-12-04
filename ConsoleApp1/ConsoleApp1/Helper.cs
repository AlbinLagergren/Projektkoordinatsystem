using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class Helper
    {
        public enum shapes // Lista för figurererna som är rangordnade efter heltal 0-7.
        {
            CIRCLE,
            TRIANGLE,
            SQUARE,
            PENTAGON,
            HEXAGON,
            HEPTAGON,
            OCTAGON
        }
        public string[] normalizeInput(string input)
        {
            string[] inputs = { "" };
            try
            {
               inputs = input.Split(";"); // Splittar efter ";"

                return inputs;
            }
            catch
            {
                return null;
            }
        }

        /* public int getTotalShapeScores(ShapeScore[] shapeScores) //Hämta totala shapescore
        {
            int total = 0;
            foreach (ShapeScore shapeScore in shapeScores)
            {
                total += shapeScore.getScore();
            }
            return total;
        }
        public int getTotalPointScores(Point[] pointScores) //Hämta totala poängen
        {
            int total = 0;
            foreach (Point pointScore in pointScores)
            {
                total += pointScore.getX() + pointScore.getY();
            }
            return total;
        }*/
    }
}
