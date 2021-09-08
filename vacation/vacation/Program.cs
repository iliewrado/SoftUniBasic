using System;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartPrice = 0;
            double priceStudioStay = 0;
            double priceApartStay = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                priceApartStay = (apartPrice = 65) * days;
                if (days > 7 && days < 14)
                {
                    priceStudioStay = (studioPrice - (studioPrice * 0.05)) * days;
                }
                else if (days > 14)
                {
                    priceStudioStay = (studioPrice - (studioPrice * 0.30)) * days;
                    priceApartStay = (apartPrice - (apartPrice * 0.10)) * days;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudioStay= (studioPrice = 75.20) * days;
                priceApartStay = (apartPrice = 68.70) * days;
                
                if (days > 14)
                {
                    priceStudioStay = (studioPrice - (studioPrice * 0.20)) * days;
                    priceApartStay = (apartPrice - (apartPrice * 0.10)) * days;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceStudioStay = (studioPrice = 76) * days;
                priceApartStay = (apartPrice = 77) * days;

                if (days > 14)
                {
                    priceApartStay = (apartPrice - (apartPrice * 0.10)) * days;
                }
            }
            Console.WriteLine($"Apartment: {priceApartStay:f2} lv.");
            Console.WriteLine($"Studio: {priceStudioStay:f2} lv.");
        }
    }
}