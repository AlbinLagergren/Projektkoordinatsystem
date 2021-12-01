using System;
namespace Pakistan
{
    class ShapeScore
    {
        private int score;
        private string shape;
        public ShapeScore(int score, string shape)
        {
            this.score = score;
            this.shape = shape;
        }
        public int getScore()
        {
            return this.score;
        }
        public string getShape()
        {
            return this.shape;
        }

    }
}
