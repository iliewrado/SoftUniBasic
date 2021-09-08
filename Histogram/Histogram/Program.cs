using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            double count = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                count++;
                
                if (num < 200)
                {
                    p1 ++;
                }
                else if (num >= 200 && num < 400)
                {
                    p2 ++;
                }
                else if (num >= 400 && num < 600)
                {
                    p3 ++;
                }
                else if (num >= 600 && num < 800)
                {
                    p4 ++;
                }
                else if (num >= 800)
                {
                    p5 ++;
                }
            }

            Console.WriteLine($"{p1 * 100 / count:f2}%");
            Console.WriteLine($"{p2 * 100 / count:f2}%");
            Console.WriteLine($"{p3 * 100 / count:f2}%");
            Console.WriteLine($"{p4 * 100 / count:f2}%");
            Console.WriteLine($"{p5 * 100 / count:f2}%");

        }
    }
}
