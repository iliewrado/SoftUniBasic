using System;

namespace problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            char pent = 'L';
            char apart = 'A';
            char office = 'O';


            for (int f = floors; f >= 1; f--)
            {
                for (int r = 0; r < rooms; r++)
                {
                    if (f == floors)
                    {
                        Console.Write($"{pent}{f}{r} ");
                    }
                    else if (f % 2 != 0)
                    {
                        Console.Write($"{apart}{f}{r} ");
                    }
                    else if (f % 2 == 0)
                    {
                        Console.Write($"{office}{f}{r} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
