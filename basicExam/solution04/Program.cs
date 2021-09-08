using System;

namespace solution04
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());

            double totalLiters = 0;
            double totalDegrees = 0;
            double allDegree = 0;


            for (int i = 0; i < days; i++)
            {
                double liters = double.Parse(Console.ReadLine());
                double degrees = double.Parse(Console.ReadLine());

                totalDegrees = degrees * liters;
                allDegree += totalDegrees;
                totalLiters += liters;
            }
            double avarageDegre = allDegree / totalLiters;
            
            Console.WriteLine($"Liter: {totalLiters:f2}");
            Console.WriteLine($"Degrees: {avarageDegre:f2}");
            if (avarageDegre <= 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (avarageDegre > 38 && avarageDegre <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (avarageDegre > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
