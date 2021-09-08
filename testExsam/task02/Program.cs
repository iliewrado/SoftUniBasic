using System;

namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {

            int minuteswalk = int.Parse(Console.ReadLine());
            int walkTimes = int.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());

            int totalWalking = minuteswalk * walkTimes;
            int burnedCalories = totalWalking * 5;

            if (burnedCalories >= calories / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
            }
        }
    }
}
