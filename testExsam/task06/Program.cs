using System;

namespace task06
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentDays = int.Parse(Console.ReadLine());
            double money = 0;
            int winCount = 0;
            int loseCount = 0;
            string result = "";
            double totalReased = 0;
            int totalWin = 0;
            int totalLose = 0;


            for (int i = 0; i < tournamentDays; i++)
            {
                string sport = Console.ReadLine();

                while (result != "Finish")
                {
                    result = Console.ReadLine();

                    switch (result)
                    {
                        case "win":
                            money += 20;
                            winCount++;
                            break;
                        case "lose":
                            loseCount++;
                            break;
                    }
                }
                if (winCount > loseCount)
                {
                    money += money * 0.10;
                }
                totalWin += winCount;
                totalLose += loseCount;
                loseCount = 0;
                winCount = 0;
                result = "";
                totalReased += money;
                money = 0;

            }
            if (totalWin > totalLose)
            {
                totalReased += totalReased * 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalReased:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalReased:f2}");
            }
        }
    }
}
