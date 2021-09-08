using System;

namespace preExam02
{
    class Program
    {
        static void Main(string[] args)
        {
            double overLugagge = double.Parse(Console.ReadLine());
            double kiloBag = double.Parse(Console.ReadLine());
            int daysUntil = int.Parse(Console.ReadLine());
            int numBags = int.Parse(Console.ReadLine());

            if (kiloBag < 10)
            {
                overLugagge *= 0.20;

                if (daysUntil > 30)
                {
                    overLugagge = overLugagge + (overLugagge * 0.10);
                }
                else if (daysUntil <= 30 && daysUntil >= 7)
                {
                    overLugagge = overLugagge + (overLugagge * 0.15);
                }
                else if (daysUntil < 7)
                {
                    overLugagge = overLugagge + (overLugagge * 0.40);
                }
            }
            else if (kiloBag >= 10 && kiloBag <= 20)
            {
                overLugagge /= 2;

                if (daysUntil > 30)
                {
                    overLugagge = overLugagge + (overLugagge * 0.10);
                }
                else if (daysUntil <= 30 && daysUntil >= 7)
                {
                    overLugagge = overLugagge + (overLugagge * 0.15);
                }
                else if (daysUntil < 7)
                {
                    overLugagge = overLugagge + (overLugagge * 0.40);
                }
            }
            else
            {
                if (daysUntil > 30)
                {
                    overLugagge = overLugagge + (overLugagge * 0.10);
                }
                else if (daysUntil <= 30 && daysUntil >= 7)
                {
                    overLugagge = overLugagge + (overLugagge * 0.15);
                }
                else if (daysUntil < 7)
                {
                    overLugagge = overLugagge + (overLugagge * 0.40);
                }
            }

            double totalPrice = overLugagge * numBags;

            Console.WriteLine($"The total price of bags is: {totalPrice:f2} lv.");
        }
    }
}
