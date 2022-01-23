using System;
using System.Collections.Generic;
using System.Text;
namespace JACOB
{
    public class PointScore
    {
        public Vector2 V { get; private set; }
        public double Score; //{ get; private set; }


        public PointScore(Vector2 v, double score)
        {
            this.V = v;
            this.Score = score;
        }



    }
}
