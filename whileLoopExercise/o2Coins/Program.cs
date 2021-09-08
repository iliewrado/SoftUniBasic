using System;

namespace o2Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());

            double convert = change * 100;
            int coin = (int)convert;
            int counter = 0;

            while (coin > 0)
            {
                if (coin - 200 >= 0)
                {
                    counter++;
                    coin -= 200;
                }
                else if (coin - 100 >= 0)
                {
                    counter++;
                    coin -= 100;
                }
                else if (coin - 50 >= 0)
                {
                    counter++;
                    coin -= 50;
                }
                else if (coin - 20 >= 0)
                {
                    counter++;
                    coin -= 20;
                }
                else if (coin - 10 >= 0)
                {
                    counter++;
                    coin -= 10;
                }
                else if (coin - 5 >= 0)
                {
                    counter++;
                    coin -= 5;
                }
                else if (coin - 2 >= 0)
                {
                    counter++;
                    coin -= 2;
                }
                else if (coin - 1 >= 0)
                {
                    counter++;
                    coin -= 1;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
