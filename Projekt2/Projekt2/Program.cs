using System;

namespace Projekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(args, new Input());

            Console.WriteLine(game.ScoreCalculation());
        }
    }
}
