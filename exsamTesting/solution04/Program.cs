using System;

namespace solution04
{
    class Program
    {
        static void Main(string[] args)
        {

            int voucer = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int ticketCount = 0;
            int orderCount = 0;
            int orderPrice = 0;

            while (input != "End")
            {
                
                int order = input.Length;

                if (order > 8)
                {
                    orderPrice = input[0] + input[1];
                    if (orderPrice > voucer)
                    {
                        break;
                    }
                    ticketCount++;

                }
                else if (order <= 8)
                {
                    orderPrice = input[0];
                    if (orderPrice > voucer)
                    {
                        break;
                    }
                    orderCount++;
                }
                
                voucer -= orderPrice;
                input = Console.ReadLine();

            }
            Console.WriteLine(ticketCount);
            Console.WriteLine(orderCount);
        }
    }
}
