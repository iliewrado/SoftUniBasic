using System;

namespace preExam03
{
    class Program
    {
        static void Main(string[] args)
        {

            string movieName = Console.ReadLine(); 
            string hallType = Console.ReadLine(); 
            int numOfTickets = int.Parse(Console.ReadLine());

            double ticketPrice = 0;

            if (movieName == "A Star Is Born")
            {
                switch (hallType)
                {
                    case "normal":
                        ticketPrice = 7.50; break;
                    case "luxury":
                        ticketPrice = 10.50; break;
                    case "ultra luxury":
                        ticketPrice = 13.50; break;
                }
            }
            else if (movieName == "Bohemian Rhapsody")
            {
                switch (hallType)
                {
                    case "normal":
                        ticketPrice = 7.35; break;
                    case "luxury":
                        ticketPrice = 9.45; break;
                    case "ultra luxury":
                        ticketPrice = 12.75; break;
                }
            }
            else if (movieName == "Green Book")
            {
                switch (hallType)
                {
                    case "normal":
                        ticketPrice = 8.15; break;
                    case "luxury":
                        ticketPrice = 10.25; break;
                    case "ultra luxury":
                        ticketPrice = 13.25; break;
                }
            }
            else if (movieName == "The Favourite")
            {
                switch (hallType)
                {
                    case "normal":
                        ticketPrice = 8.75; break;
                    case "luxury":
                        ticketPrice = 11.55; break;
                    case "ultra luxury":
                        ticketPrice = 13.95; break;
                }
            }
            double totalSum = numOfTickets * ticketPrice;

            Console.WriteLine($"{movieName} -> {totalSum:f2} lv.");
        }
    }
}
