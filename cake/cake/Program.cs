using System;

namespace cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int wide = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cakeSize = wide * lenght;
            int cuts = 0;

            string input = Console.ReadLine();
            
            while (input != "STOP")
            {
                int pieces = int.Parse(input);
                cuts += pieces;

                if (cuts >= cakeSize)
                {
                    Console.WriteLine($"No more cake left! You need {cuts - cakeSize} pieces more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{cakeSize - cuts} pieces are left.");
            }
        }
    }
}
