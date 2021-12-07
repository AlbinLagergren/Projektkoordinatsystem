using System;
using System.Collections.Generic;
using System.Text;
namespace JACOB
{
    public interface Shape
    {
        public string Shapename { get; set; }
        public bool Inside(Vector2 p);

        public double CalcArea();

    }
}
