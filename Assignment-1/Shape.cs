using System;
namespace Assignment
{
    class Shape
    {
        protected int x;
        public int y;
        public int perimeter;
        public Shape(int x, int y, int perimeter) 
        { 
            this.x = x;
            this.y = y; 
            this.perimeter = perimeter; 
        }
        public virtual string hitOrMiss(PointScore pointScore)
        {
            return "null";
        }
        public int getX()
        {
            return this.x;
        }
        public int getY()
        {
            return this.y;
        }
        public int getPerimeter()
        {
            return this.perimeter;
        }
    }
}
