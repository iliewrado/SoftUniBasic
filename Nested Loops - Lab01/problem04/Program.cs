using System;

namespace problem04
{
    class Program
    {
        static void Main(string[] args)
        {

            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            bool found = false;
            int combinationNum = 0;

            for (int i = startNum; i <= endNum; i++)
            {


                for (int j = startNum; j <= endNum; j++)
                {
                    combinationNum++;
                    
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinationNum} ({i} + {j} = {magicNum})");
                        found = true;
                        break;
                        
                    }

                }
                if (found == true)
                {
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine($"{combinationNum} combinations - neither equals {magicNum}");
            }
            
        }
    }
}
