using System;

namespace realPreExam06
{
    class Program
    {
        static void Main(string[] args)
        {

            int locations = int.Parse(Console.ReadLine());
            
            double digetGold = 0;
            double totalDig = 0;

            for (int j = 0; j < locations; j++)
            {
                double averageGold = double.Parse(Console.ReadLine());
                int daysOfDiging = int.Parse(Console.ReadLine());
                digetGold = 0;
                totalDig = 0;


                for (int i = 0; i < daysOfDiging; i++)
                {
                    digetGold = double.Parse(Console.ReadLine());
                    totalDig += digetGold;
                }
                double averageAmaun = totalDig / daysOfDiging;

                if (averageAmaun >= averageGold)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageAmaun:f2}.");
                    continue;
                }
                else if (averageAmaun < averageGold)
                {
                    Console.WriteLine($"You need {(averageGold - averageAmaun):f2} gold.");
                    continue;

                }
                
            }

        }
    }
}
