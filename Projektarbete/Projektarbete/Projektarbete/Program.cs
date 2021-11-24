using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Projektarbete
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Pointscore> listOfCoordinates = new List<Pointscore>()
                {
                new Pointscore() { X = -50, Y = 1 , S = 5 },
                new Pointscore() { X = -10, Y = 5 , S = 5 },
                new Pointscore() { X = -50, Y = 1 , S = 5 }

                };

            List<Shape> listOfShapes = new List<Shape>()
            { 
                    new Shape("Circle", 2, 2, 10), {shapeName = "Circle", x = 2, y = 5, Perimeter = 10}, 
                    new Shape("Circle", 2, 2, 10) {shapeName = "Triangle", x = 2, y = 5, Perimeter = 10},
                    new Shape() {shapeName = "Pentagon", x = 2, y = 5, Perimeter = 10},
                    new Shape() {shapeName = "Hexagon", x = 2, y = 5, Perimeter = 10},
                    new Shape() {shapeName = "Heptagon", x = 2, y = 5, Perimeter = 10},
                    new Shape() {shapeName = "Octagon", x = 2, y = 5, Perimeter = 10},
                    new Shape() {shapeName = "Square", x = 3, y = 8, Perimeter = 10}

            };
            
            

            List<ShapeScore> listOfShapesScore = new List<ShapeScore>()
            {

                new ShapeScore() { shapeName = "Circle", shapePoints = 100 },
                new ShapeScore() { shapeName = "Circle", shapePoints = 100 },
                new ShapeScore() { shapeName = "Circle", shapePoints = 100 },
                new ShapeScore() { shapeName = "Circle", shapePoints = 100 },
                new ShapeScore() { shapeName = "Circle", shapePoints = 100 },
                new ShapeScore() { shapeName = "Circle", shapePoints = 100 },
                new ShapeScore() { shapeName = "Circle", shapePoints = 100 }
            };

        }

        List<Pointscore> shapes = new List<Pointscore>();

        coordinate square = new Square(5, 3, 100);
        coordinate circle = new Circle(1, 3, 100);
        

        
    }


}







