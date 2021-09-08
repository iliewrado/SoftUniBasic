using System;

namespace solution06
{
    class Program
    {
        static void Main(string[] args)
        {

            string num = Console.ReadLine();

            int num1 = num[2] - 48;
            int num2 = num[1] - 48;
            int num3 = num[0] - 48;
            

            for (int i = 1; i <= num1 ; i++)
            {
                for (int j = 1; j <= num2; j++)
                {
                    for (int k = 1; k <= num3; k++)
                    {

                        Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
                    }
                }
            }


        }
    }
}
