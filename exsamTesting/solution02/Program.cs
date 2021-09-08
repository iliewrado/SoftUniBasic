using System;

namespace solution02
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int statistsNum = int.Parse(Console.ReadLine());
            double outfit = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double outfitPrice = statistsNum * outfit;
            if (statistsNum > 150)
            {
                outfitPrice -= outfitPrice * 0.10;
            }
            double totalAmount = decor + outfitPrice;
            if (totalAmount <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - totalAmount):f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(totalAmount - budget):f2} leva more.");
            }
        }
    }
}
