using System;

namespace task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Watermelon", "Mango", "Pineapple" или "Raspberry"
            string fruitType = Console.ReadLine();
            //2.	Размерът на сета - текст с възможности: "small" 2br. или "big" 5br.
            string sethType = Console.ReadLine();
            int orderNum = int.Parse(Console.ReadLine());

            double price = 0;

            if (sethType == "small")
            {
                switch (fruitType)
                {
                    case "Watermelon":
                        price = 56 * 2;
                        break;
                    case "Mango":
                        price = 36.66 * 2;
                        break;
                    case "Pineapple":
                        price = 42.10 * 2;
                        break;
                    case "Raspberry":
                        price = 20 * 2;
                            break;
                }
            }
            else
            {
                switch (fruitType)
                {
                    case "Watermelon":
                        price = 28.70 * 5;
                        break;
                    case "Mango":
                        price = 19.60 * 5;
                        break;
                    case "Pineapple":
                        price = 24.80 * 5;
                        break;
                    case "Raspberry":
                        price = 15.20 * 5;
                        break;
                }
            }
            double totalSum = orderNum * price;

            if (totalSum >= 400 && totalSum <= 1000)
            {
                totalSum -= totalSum * 0.15;
            }
            else if (totalSum > 1000)
            {
                totalSum -= totalSum * 0.50;
            }

            Console.WriteLine($"{(totalSum):f2} lv.");
        }
    }
}
