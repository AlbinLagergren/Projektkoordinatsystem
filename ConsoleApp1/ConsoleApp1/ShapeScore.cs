using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
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
        public int getScore() //metod som hämtar poäng
        {
            return this.score;
        }
        public string getShape() //metod som hämtar score
        {
            return this.shape;
        }
    }
}
