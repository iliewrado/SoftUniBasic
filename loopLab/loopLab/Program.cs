using System;

namespace loopLab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int smal = int.MinValue;
            int big = int.MaxValue;
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                
                if (numb > smal)
                {
                    smal = numb;
                }
                if (numb < big)
                {
                    big = numb;
                }
            }

            Console.WriteLine($"Max number: {smal}");
            Console.WriteLine($"Min number: {big}");

        }
    }
}
