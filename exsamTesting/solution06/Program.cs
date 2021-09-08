using System;

namespace solution06
{
    class Program
    {
        static void Main(string[] args)
        {

            string movieName = "";
            string ticketType = "";
            int totalStudent = 0;
            int totalStandard = 0;
            int totalKid = 0;
            double totalTickets = 0;
            double freePlaces = 0;

            while (movieName != "Finish")
            {
                movieName = Console.ReadLine();

                int student = 0;
                int standard = 0;
                int kid = 0;

                if (movieName == "Finish")
                {
                    break;
                }
                freePlaces = double.Parse(Console.ReadLine());

                for (int current = 1; current <= freePlaces; current++)
                {
                    ticketType = Console.ReadLine();

                    if (ticketType == "student")
                    {
                        student++;
                    }
                    else if (ticketType == "standard")
                    {
                        standard++;
                    }
                    else if (ticketType == "kid")
                    {
                        kid++;
                    }
                    else if (ticketType == "End")
                    {
                        break;
                    }

                }
                totalKid += kid;
                totalStandard += standard;
                totalStudent += student;
                totalTickets = totalKid + totalStandard + totalStudent;
                int totalSingle = kid + student + standard;

                Console.WriteLine($"{movieName} - {((totalSingle / freePlaces) * 100):f2}% full.");

            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{((totalStudent / totalTickets) * 100):f2}% student tickets.");
            Console.WriteLine($"{((totalStandard / totalTickets) * 100):f2}% standard tickets.");
            Console.WriteLine($"{((totalKid / totalTickets) * 100):f2}% kids tickets.");



        }
    }
}
