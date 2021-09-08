using System;

namespace realPreExam03
{
    class Program
    {
        static void Main(string[] args)
        {

            string cakeType = Console.ReadLine();
            int order = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            
            double price = 0;
            double dicount = 0;
            double totalPrice = 0;

            if (day > 15)
            {
                switch (cakeType)
                {
                    case "Cake":
                        price = 28.70; break;
                    case "Souffle":
                        price = 9.80; break;
                    case "Baklava":
                        price = 16.98; break;
                 
                }
            }
            else if (day <= 15)
            {
                switch (cakeType)
                {
                    case "Cake":
                        price = 24.00; break;
                    case "Souffle":
                        price = 6.66; break;
                    case "Baklava":
                        price = 12.60; break;
                }
            }
            totalPrice = price * order;
            if (totalPrice >= 100 && totalPrice <= 200 && day <= 22)
            {
                totalPrice *= 0.85;
            }
            else if (totalPrice > 200 && day <= 22)
            {
                totalPrice *= 0.75;
            }
            if (day <= 15)
            {
                totalPrice *= 0.90;
            }
            

          Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
