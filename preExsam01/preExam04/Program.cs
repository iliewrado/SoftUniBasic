using System;

namespace preExam04
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int numOfSeries = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < numOfSeries; i++)
            {
                string seriesName = Console.ReadLine();
                double seriesPrice = double.Parse(Console.ReadLine());  

                switch (seriesName)
                {
                    case "Thrones":
                        seriesPrice *= 0.50; break;
                    case "Lucifer":
                        seriesPrice *= 0.60; break;
                    case "Protector":
                        seriesPrice *= 0.70; break;
                    case "TotalDrama":
                        seriesPrice *= 0.80; break;
                    case "Area":
                        seriesPrice *= 0.90; break;
                }
                sum += seriesPrice;
                
            }
            if (sum <= budget)
            {
                Console.WriteLine($"You bought all the series and left with {(budget - sum):f2} lv.");
                
            }
            else
            {
                Console.WriteLine($"You need {(sum - budget):f2} lv. more to buy the series!");
                
            }
        }
    }
}
