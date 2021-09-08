using System;

namespace preExam06
{
    class Program
    {
        static void Main(string[] args)
        {

            int finalGoal = int.Parse(Console.ReadLine());

            int goal = finalGoal - 30;

            int jumpsCounter = 0;
            int badjumpsCounter = 0;

            while (goal <= finalGoal)
            {
                int jump = int.Parse(Console.ReadLine());
                jumpsCounter++;

                if (jump > goal)
                {
                    goal += 5;
                    badjumpsCounter = 0;
                }
                else
                {
                    badjumpsCounter++;
                }
                if (badjumpsCounter == 3)
                {
                    Console.WriteLine($"Tihomir failed at {goal}cm after {jumpsCounter} jumps.");
                    return;
                }
            }
            if (goal > finalGoal)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {goal-5}cm after {jumpsCounter} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir failed at {goal}cm after {jumpsCounter} jumps.");
            }



        }
    }
}
