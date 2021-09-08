using System;

namespace task04
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            double foodAmount = double.Parse(Console.ReadLine());

            double totalDog = 0;
            double totalCat = 0;
            double cookies = 0;
            double eatenFood = 0;
            double allCookies = 0;

            int count = 0;

            for (int i = 1; i <= days; i++)
            {
                int dogEaten = int.Parse(Console.ReadLine());
                int catEaten = int.Parse(Console.ReadLine());

                eatenFood += dogEaten;
                eatenFood += catEaten;
                totalDog += dogEaten;
                totalCat += catEaten;
                count ++;

                if (count == 3)
                {
                    cookies = (dogEaten + catEaten) * 0.10;
                    allCookies += cookies;
                    count = 0;
                }
                

            }
            double foodPrecent = (eatenFood / foodAmount) * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(allCookies)}gr.");
            Console.WriteLine($"{foodPrecent:f2}% of the food has been eaten.");
            Console.WriteLine($"{((totalDog / eatenFood) * 100):f2}% eaten from the dog.");
            Console.WriteLine($"{((totalCat / eatenFood) *100):f2}% eaten from the cat.");
        }
    }
}
