using System;

namespace NestedLoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 1;

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count++;
                    if (count > num)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
