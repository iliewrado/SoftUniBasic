using System;

namespace preExam05
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            double sumHonorar = 0;
            double actorHonorar = 0;

            while (sumHonorar <= budget)
            {
                string actorName = Console.ReadLine();
                if (actorName != "ACTION")
                {
                    int lenthName = actorName.Length;
                    
                    if (lenthName > 15)
                    {
                        actorHonorar = (budget - sumHonorar) * 0.20;
                        sumHonorar += actorHonorar;
                    }
                    else
                    {
                        actorHonorar = double.Parse(Console.ReadLine());
                        sumHonorar += actorHonorar;
                    }
                    
                }
                else if (actorName == "ACTION")
                {
                    break;
                }
            }
            if (sumHonorar <= budget)
            {
                Console.WriteLine($"We are left with {(budget - sumHonorar):f2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {(sumHonorar - budget):f2} leva for our actors.");
            }
        }
    }
}
