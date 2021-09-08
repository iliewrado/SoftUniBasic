using System;

namespace solution01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRollsPaper = int.Parse(Console.ReadLine());
            int numRollsCloth = int.Parse(Console.ReadLine());
            double glueLiters = double.Parse(Console.ReadLine());
            int dicount = int.Parse(Console.ReadLine());

            double paperPrice = numRollsPaper * 5.80;
            double clothPrice = numRollsCloth * 7.20;
            double gluePrice = glueLiters * 1.20;

            double totalPrice = paperPrice + clothPrice + gluePrice;
            double amountTopay = totalPrice - ((totalPrice * dicount) / 100);


            Console.WriteLine($"{amountTopay:f3}");
        }
    }
}
