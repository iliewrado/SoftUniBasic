using System;

namespace solution05
{
    class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();
            int days = 1;
            int totalMeters = 5364;


            while (command != "END")
            {
                if (command == "Yes")
                {
                    days++;
                }
                
                int meters = int.Parse(Console.ReadLine());
                totalMeters += meters;
                if (days == 5)
                {
                    break;
                }
                if (totalMeters >= 8848)
                {
                    Console.WriteLine($"Goal reached for {days} days!");
                    break;
                }
                
                command = Console.ReadLine();
            }
            if (totalMeters < 8848)
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(totalMeters);
            }

        }
    }
}
