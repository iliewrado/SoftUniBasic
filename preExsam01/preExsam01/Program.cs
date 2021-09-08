using System;

namespace preExsam01
{
    class Program
    {
        static void Main(string[] args)
        {

            double singlerocketPrice = double.Parse(Console.ReadLine());
            int numOfRockets = int.Parse(Console.ReadLine());
            int numOfSnickers = int.Parse(Console.ReadLine());

            double allRocketPrice = singlerocketPrice * numOfRockets;
            double snickersPrice = (singlerocketPrice / 6) * numOfSnickers;
            double odderEquipment = (allRocketPrice + snickersPrice) * 0.20;
            double totalAmount = allRocketPrice + odderEquipment + snickersPrice;
            
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(totalAmount * 1 / 8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(totalAmount * 7/8)}");
        }
    }
}
