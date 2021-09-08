using System;

namespace realPreExam02
{
    class Program
    {
        static void Main(string[] args)
        {

            int procesorsNeeded = int.Parse(Console.ReadLine());
            int wokers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            int totalTime = wokers * workingDays * 8;
            double production = Math.Floor(totalTime / 3.0);
            double profit = (production - procesorsNeeded)* 110.10;


            if (production >= procesorsNeeded)
            {
                Console.WriteLine($"Profit: -> {profit:f2} BGN");
            }
            else
            {
                Console.WriteLine($"Losses: -> {((procesorsNeeded - production) * 110.10):f2} BGN");
            }
            
        }
    }
}
