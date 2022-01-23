using System;
using System.Collections.Generic;
using System.Text;
namespace JACOB
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            HandleInput test = new HandleInput(args);

            Console.WriteLine(test.Start());

        }
    }
}
