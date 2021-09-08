using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            double boatPriceSummer = 4200;
            double boatPriceWinter = 2600;
            double boatPriceSpring = 3000;
            double totalAmount = 0;

            
            if (season == "Spring")
            {
                    if (fisherman <= 6)
                    {
                        totalAmount = boatPriceSpring - (boatPriceSpring * 0.10);
                    }
                    else if (fisherman >= 7 && fisherman <= 11)
                    {
                        totalAmount = boatPriceSpring - (boatPriceSpring * 0.15);
                    }
                    else if (fisherman >=12)
                    {
                        totalAmount = boatPriceSpring - (boatPriceSpring * 0.25);
                    }
                    
            }
            else if (season == "Summer" || season == "Autumn")
            {
                if (fisherman <= 6)
                {
                    totalAmount = boatPriceSummer - (boatPriceSummer * 0.10);
                }
                else if (fisherman >= 7 && fisherman <= 11)
                {
                    totalAmount = boatPriceSummer - (boatPriceSummer * 0.15);
                }
                else if (fisherman >= 12)
                {
                    totalAmount = boatPriceSummer - (boatPriceSummer * 0.25);
                }
            }
            else if (season == "Winter")
            {
                if (fisherman <= 6)
                {
                    totalAmount = boatPriceWinter - (boatPriceWinter * 0.10);
                }
                else if (fisherman >= 7 && fisherman <= 11)
                {
                    totalAmount = boatPriceWinter - (boatPriceWinter * 0.15);
                }
                else if (fisherman >= 12)
                {
                    totalAmount = boatPriceWinter - (boatPriceWinter * 0.25);
                }
            }
            if (fisherman % 2 == 0 && season != "Autumn")
            {
                
                totalAmount -= totalAmount * 0.05;
            }
            if (totalAmount <= budjet)
            {
                Console.WriteLine($"Yes! You have {(budjet - totalAmount):f2} leva left.");
            }
            else if (totalAmount > budjet)
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budjet - totalAmount):f2} leva.");
            }
        }
    }
}
