using System;

namespace loopExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            double n = double.Parse(Console.ReadLine());

            double OddSum = 0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;
            double EvenSum = 0;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    OddSum += num;
                    if (num > OddMax)
                    {
                        OddMax = num;
                    }
                    if (num <OddMin)
                    {
                        OddMin = num;
                    }
                }
                if (i % 2 == 0)
                {
                    EvenSum += num;
                    if (num > EvenMax)
                    {
                        EvenMax = num;
                    }
                    if (num < EvenMin)
                    {
                        EvenMin = num;
                    }
                }

            }

            Console.WriteLine($"OddSum={OddSum:f2},");

            if (n >= 1)
            {
                Console.WriteLine($"OddMin={OddMin:f2},");
                Console.WriteLine($"OddMax={OddMax:f2},");
            }
            else
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }

            Console.WriteLine($"EvenSum={EvenSum:f2},");

            if (n >= 2)
            {
                Console.WriteLine($"EvenMin={EvenMin:f2},");
                Console.WriteLine($"EvenMax={EvenMax:f2}");
            }
            else
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }

        }
    }
}
