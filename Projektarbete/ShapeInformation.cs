using System;
using System.Collections.Generic;
using System.Text;

namespace Projektarbete
{
    public abstract class ShapeInformation
    {
        public PointScore MiddlePoint { get; set; }
        public double Perimeter { get; set; }
        public double Radius { get; set; }
        public double Area { get; set; }
        public string TypeOfShape { get; set; }
  
    }   
}
