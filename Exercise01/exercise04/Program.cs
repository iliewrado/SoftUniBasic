using System;

namespace exercise04
{
    class Program
    {
        static void Main(string[] args)
        {

            int jury = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();

            int counter = 0;
            double totalScore = 0;
            

            while (presentationName != "Finish")
            {
                double avaregeSore = 0;
                
                for (int i = 0; i < jury; i++)
                {
                    double score = double.Parse(Console.ReadLine());
                    avaregeSore += score;
                    counter++;
                }
                totalScore += avaregeSore;
                Console.WriteLine($"{presentationName} - {(avaregeSore / jury):f2}.");
                presentationName = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {(totalScore / counter):f2}.");
        }
    }
}
