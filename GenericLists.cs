using System;
using System.Collections.Generic;
using System.Text;
namespace OOP1
{
    public class GenericLists
    {
        public GenericLists()
        {
            

                List<Coordinates> listOfCoordinates = new List<Coordinates>();

                List<Shape> listOfShapes = new List<Shape>();

            listOfShapes.Add(new Shape("Circle", 2, 2, 10));

            Dictionary<string, int> listOfShapeScore = new Dictionary<string, int>();
            listOfShapeScore.Add("Circle", 15);

                

                

        }

        

    }
}
