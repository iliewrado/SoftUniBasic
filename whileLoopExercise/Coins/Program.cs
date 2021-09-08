using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {

            double change = double.Parse(Console.ReadLine());

            double convert = change * 100;
            int coin = (int) convert;
            int counter = 0;

            int amount = coin % 200;
            counter += coin / 200;
            coin = amount;
            amount = coin % 100;
            counter += coin / 100;
            coin = amount;
            amount = coin % 50;
            counter += coin / 50;
            coin = amount;
            amount = coin % 20;
            counter += coin / 20;
            coin = amount;
            amount = coin % 10;
            counter += coin / 10;
            coin = amount;
            amount = coin % 5;
            counter += coin / 5;
            coin = amount;
            amount = coin % 2;
            counter += coin / 2;
            coin = amount;
            amount = coin % 1;
            counter += coin / 1;
            coin = amount;

            Console.WriteLine(counter);
        }
    }
}
