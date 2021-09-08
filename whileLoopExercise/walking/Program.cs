using System;

namespace walking
{
    class Program
    {
        static void Main(string[] args)
        {

            const int GOAL = 10000;
            int steps = 0;
            int totalSteps = 0;

            while (steps <= GOAL)
            {
                string input = Console.ReadLine();
                if (input != "Going home")
                {
                    steps = int.Parse(input);
                    totalSteps += steps;
                }
                else if (input == "Going home")
                {
                    steps = int.Parse(Console.ReadLine());
                    totalSteps += steps;
                    if (totalSteps < GOAL)
                    {
                        Console.WriteLine($"{GOAL - totalSteps} more steps to reach goal.");
                        break;
                    }
                }
                if (totalSteps >= GOAL)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - GOAL} steps over the goal!");
                    break;
                }
            }
            
        }
    }
}
