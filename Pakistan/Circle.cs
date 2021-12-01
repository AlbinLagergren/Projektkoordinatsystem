using System;
namespace Pakistan
{
    class Circle : Shape
    {
        public Circle(int x, int y, int perimeter) : base(x, y, perimeter) { }
        public override string hitOrMiss(PointScore pointScore)
        {
            Helper helper = new Helper();
            double distance = helper.calculateDistance(pointScore.getX(), this.x, pointScore.getY(), this.y);
            double radius = perimeter / 2 * Math.PI;
            return radius >= distance ? "Hit" : "Miss";
        }
    }
}
