using System;

namespace solution01
{
    class Program
    {
        static void Main(string[] args)
        {

            int hallRent = int.Parse(Console.ReadLine());

            double statue = hallRent - (hallRent * 0.30);
            double catering = statue - (statue * 0.15);
            double audio = catering / 2;
            double totalAmount = hallRent + statue + catering + audio;
            
            
            Console.WriteLine($"{totalAmount:f2}");
        }
    }
}
