using System;

namespace realPreExam05
{
    class Program
    {
        static void Main(string[] args)
        {
            int kidsCounter = 0;
            int adultCounter = 0;
            double toys = 5;
            double sweaters = 15;
            string input = Console.ReadLine();

            while (input != "Christmas")
            {
                int age = int.Parse(input);
                if (age <= 16)
                {
                    kidsCounter++;
                }
                else if (age > 16)
                {
                    adultCounter++;
                }
                input = Console.ReadLine();
            }
            double toysPrice = toys * kidsCounter;
            double sweatersPrice = adultCounter * sweaters;
            
            Console.WriteLine($"Number of adults: {adultCounter}");
            Console.WriteLine($"Number of kids: {kidsCounter}");
            Console.WriteLine($"Money for toys: {toysPrice}");
            Console.WriteLine($"Money for sweaters: {sweatersPrice}");
        }
    }
}
