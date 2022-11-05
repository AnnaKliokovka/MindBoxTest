using System;
using MindTestLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure figure = new TCircle(3);
            Console.WriteLine(figure.CalculateArea());
        }
    }
}
