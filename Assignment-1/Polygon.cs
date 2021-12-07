using System;
namespace Assignment
{
    class Polygon : Shape
    {
        private int sides;
        public Polygon(int x, int y, int perimeter,int sides) : base(x, y, perimeter) 
        {
            this.sides = sides;
        }

        public override string hitOrMiss(PointScore pointScore)
        {
            Helper helper = new Helper();
            double distance = helper.calculateDistance(pointScore.getX(), this.x, pointScore.getY(), this.y);
            int perSideValue = perimeter / sides;
            return distance <= perSideValue / 2 ? "Hit" : "Miss";
        }
    }
}
