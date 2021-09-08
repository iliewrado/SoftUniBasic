using System;

namespace problem05
{
    class Program
    {
        static void Main(string[] args)
        {

            string destination = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());

            double amount = 0;
            
            while (destination != "End")
            {
                double save = 0;
                
                while (true)
                {
                    amount = double.Parse(Console.ReadLine());
                    save += amount;
                    if (save >= price)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                price = double.Parse(Console.ReadLine());
            }
        }
    }
}
