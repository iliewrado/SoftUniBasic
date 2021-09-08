using System;

namespace task05
{
    class Program
    {
        static void Main(string[] args)
        {

            int foodKilo = int.Parse(Console.ReadLine());
            double foodGrams = foodKilo * 1000;
            string input = "";

            while (input != "Adopted")
            {
                input = Console.ReadLine();
                if (input != "Adopted")
                {
                    double grams = double.Parse(input);
                    foodGrams -= grams;
                }
                else
                {
                    break;
                }
            }
            if (foodGrams >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodGrams} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(foodGrams)} grams more.");
            }
        }
    }
}
