using System;

namespace loop100
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double result = 0;
            double numb = 0;
            for (int num = 1; num <= count; num++)
            {
                numb = double.Parse(Console.ReadLine());
                result += numb;
            }
            

            Console.WriteLine(result);

        }
    }
}
