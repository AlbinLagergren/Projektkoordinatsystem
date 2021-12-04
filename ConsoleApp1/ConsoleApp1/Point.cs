using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Point
    {
        private int X;
        private int Y;

        private double xCord { get; set; }
        private double yCord { get; set; }

        public double pointScore { get; private set; }
        public Point(int x, int y, double _pointScore)
        {
            this.X = x;
            this.Y = y;
            this.pointScore = _pointScore;
        }

        public Point(double xCord, double yCord) //ctor overloading
        {
            this.xCord = xCord;
            this.yCord = yCord;
        }

        
        public int getX() //hämtar x för att använda i HitOrMiss
        {
            return this.X;
        }
        public int getY() //hämtar y för att använda i HitOrMiss
        {
            return this.Y;
        }
        public double getxCord() //metod som hämtar x-kordinaten
        {
            return this.xCord;
        }
        public double getyCord() //metod som hämtar y-kordinaten
        {
            return this.yCord;
        }
    }
}
