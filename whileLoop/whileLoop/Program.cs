using System;

namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();

            double grade = 0;
            double gradeSum = 0;
            int counter = 1;
            gradeSum += grade;
            int badGradeCount = 0;

            while (counter <= 12)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade >= 4)
                {
                    gradeSum += grade;
                    counter++;
                }
                else
                {
                    badGradeCount++;
                }
                if (badGradeCount == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {counter} grade");
                    break;
                }
               
            }
            if (badGradeCount < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {(gradeSum / 12):f2}");
            }

        }
    }
}
