using System;

namespace solution02
{
    class Program
    {
        static void Main(string[] args)
        {

            int daysGone = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double deer1 = double.Parse(Console.ReadLine());
            double deer2 = double.Parse(Console.ReadLine());
            double deer3 = double.Parse(Console.ReadLine());

            double eaten = (deer1 * daysGone) + (deer2 * daysGone) + (deer3 * daysGone);
            
            if (foodLeft > eaten)
            {
                Console.WriteLine($"{Math.Floor(foodLeft - eaten)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Round(eaten - foodLeft)} more kilos of food are needed.");
            }
        }
    }
}
