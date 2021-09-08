using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = int.Parse(Console.ReadLine());
            double washingMashine = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double moneyGift = 10;
            double toysCount = 0;
            double stolen = 0;
            double money = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += moneyGift;
                    moneyGift += 10;
                    stolen++;
                }
                else
                {
                    toysCount++;
                }
            }
            
            double moneyFromtoys = toysCount * toysPrice;
            double finalMoney = (money + moneyFromtoys) - stolen;

            if (finalMoney >= washingMashine)
            {
                Console.WriteLine($"Yes! {(finalMoney - washingMashine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMashine - finalMoney):f2}");
            }
        }
    }
}
