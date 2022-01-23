using System;

namespace OOP1Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game(args, new ParseInput());

            Console.WriteLine(game.ScoreCalculation());

        }
    }
}