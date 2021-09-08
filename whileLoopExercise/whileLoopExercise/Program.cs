using System;

namespace whileLoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            double needetFor = double.Parse(Console.ReadLine());
            double atTheMoment = double.Parse(Console.ReadLine());

            int daysCount = 0;
            int spendDays = 0;


            while (true)
            {
                string action = Console.ReadLine();
                double actionMoney = double.Parse(Console.ReadLine());
                daysCount++;

                switch (action)
                {
                    case "spend":
                        atTheMoment -= actionMoney;
                        if (actionMoney > atTheMoment)
                        {
                            atTheMoment = 0;
                        }
                        spendDays++;
                        break;
                    case "save":
                        atTheMoment += actionMoney;
                        spendDays = 0;
                        break;
                }
                if (spendDays >= 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(daysCount);
                    break;
                }
                if (atTheMoment >= needetFor)
                {
                    Console.WriteLine($"You saved the money for {daysCount} days.");
                    break;
                }
            }
        }
    }
}
