/*
 ⦁	Лява и дясна сума
Да се напише програма, която чете 2*n-на брой цели числа, подадени от потребителя,
и проверява дали сумата на първите n числа (лява сума) е равна на сумата на вторите n числа (дясна сума).
При равенство печата " Yes, sum = " + сумата; иначе печата " No, diff = " + разликата.
Разликата се изчислява като положително число (по абсолютна стойност). 
 */

using System;


namespace _63.Left_and_Right_Sum
{
    internal class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            int numberLeft = 0;
            int numberRight = 0;
            for (int i = 0; i < loop; i++)
            {
                numberLeft += int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < loop; i++)
            {
                numberRight += int.Parse(Console.ReadLine());
            }
            if (numberLeft == numberRight) { Console.WriteLine($"Yes, sum = {numberRight}"); }
            else { Console.WriteLine($"No, diff = {Math.Abs(numberLeft-numberRight)}"); }
        }
    }
}
