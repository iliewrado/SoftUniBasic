using System;

namespace solution03
{
    class Program
    {
        static void Main(string[] args)
        {

            double pacageWaight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int mileage = int.Parse(Console.ReadLine());
            double price = 0;
            double overPrice = 0;
            double totalPrice = 0;

            switch (type)
            {
                case "standard":
                    if (pacageWaight < 1)
                    {
                        price = mileage * 0.03;
                    }
                    else if (pacageWaight >= 1 && pacageWaight < 10)
                    {
                        price = mileage * 0.05;
                    }
                    else if (pacageWaight >= 10 && pacageWaight < 40)
                    {
                        price = mileage * 0.10;
                    }
                    else if (pacageWaight >= 40 && pacageWaight < 90)
                    {
                        price = mileage * 0.15;
                    }
                    else if (pacageWaight >= 90 && pacageWaight < 150)
                    {
                        price = mileage * 0.20;
                    }
                    break;
                case "express":
                    if (pacageWaight < 1)
                    {
                        price = mileage * 0.03;
                        overPrice = (0.03 * 0.80) * pacageWaight;
                        totalPrice = overPrice * mileage;
                    }
                    else if (pacageWaight >= 1 && pacageWaight < 10)
                    {
                        price = mileage * 0.05;
                        overPrice = (0.05 * 0.40) * pacageWaight;
                        totalPrice = overPrice * mileage;
                    }
                    else if (pacageWaight >= 10 && pacageWaight < 40)
                    {
                        price = mileage * 0.10;
                        overPrice = (0.10 * 0.05) * pacageWaight;
                        totalPrice = overPrice * mileage;
                    }
                    else if (pacageWaight >= 40 && pacageWaight < 90)
                    {
                        price = mileage * 0.15;
                        overPrice = (0.15 * 0.02) * pacageWaight;
                        totalPrice = overPrice * mileage;
                    }
                    else if (pacageWaight >= 90 && pacageWaight < 150)
                    {
                        price = mileage * 0.20;
                        overPrice = (0.20 * 0.01) * pacageWaight;
                        totalPrice = overPrice * mileage;

                    }
                    break;
                    
            }
            double totalAmaunt = price + totalPrice;

            Console.WriteLine($"The delivery of your shipment with weight of {pacageWaight:f3} kg. would cost {totalAmaunt:f2} lv.");
        }
    }
}
