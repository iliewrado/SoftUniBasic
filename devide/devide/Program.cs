using System;

namespace devide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;


            double count = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                count++;

                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }

            }

            Console.WriteLine($"{p1 * 100 / count:f2}%");
            Console.WriteLine($"{p2 * 100 / count:f2}%");
            Console.WriteLine($"{p3 * 100 / count:f2}%");

        }
    }
}
