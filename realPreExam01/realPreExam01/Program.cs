using System;

namespace realPreExam01
{
    class Program
    {
        static void Main(string[] args)
        {

            double avaregeSpeed = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());

            double distance = 384400 * 2;
            double timeTo = Math.Ceiling(distance / avaregeSpeed);
            double totalTime = timeTo + 3;
            double fuelSpend = (fuel * distance) / 100;

            Console.WriteLine(Math.Ceiling(totalTime));
            Console.WriteLine(fuelSpend);
        }
    }
}
