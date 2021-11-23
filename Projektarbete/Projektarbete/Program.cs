using System;
using System.Collections.Generic;
using System.Text;

namespace Projektarbete
{
    class Program
    {
        static void Main(string[] args)
        {

            // list.Add(new Circle(5, 3, 100));
            List<Pointscore> coordinates = new List<Pointscore>()
            {
                new Pointscore() { X = -50, Y = 1 , S = 5 },
                new Pointscore() { X = -50, Y = 1 , S = 5 },
                new Pointscore() { X = -50, Y = 1 , S = 5 },
                new Pointscore() { X = -50, Y = 1 , S = 5 },
                new Pointscore() { X = -50, Y = 1 , S = 5 },
                new Pointscore() { X = -50, Y = 1 , S = 5 }
            };

            List<Pointscore> shapes = new List<Pointscore>();
            
            coordinate square = new Square(5, 3, 100);
            coordinate circle = new Circle(1, 3, 100);
            
        }   

    }


}


