using System;

namespace realPreExam04
{
    class Program
    {
        static void Main(string[] args)
        {

            int passengers = int.Parse(Console.ReadLine());
            int busStops = int.Parse(Console.ReadLine());

            int up = 0;
            int down = 0;
            int counter = 0;

            for (int i = 1; i <= busStops; i++)
            {
                down = int.Parse(Console.ReadLine());
                passengers -= down;
                up = int.Parse(Console.ReadLine());
                passengers += up;

                if (i % 2 != 0)
                {
                    passengers += 2;
                }
                if (i % 2 == 0)
                {
                    passengers -= 2;
                }
                
            }
            Console.WriteLine($"The final number of passengers is : {passengers}");
        }
    }
}
