/*
 ⦁	Четна / нечетна сума
Да се напише програма, която чете n-на брой цели числа, подадени от потребителя 
и проверява дали сумата от числата на четни позиции е равна на сумата на числата на нечетни позиции. 
⦁	Ако сумите са равни да се отпечатат два реда: "Yes" и на нов ред "Sum = " + сумата; 
⦁	Ако сумите не са равни да се отпечат два реда: "No" и на нов ред "Diff = " + разликата. 
Разликата се изчислява по абсолютна стойност. 

 */

using System;


namespace _64.Odd_Even_Sum
{
    internal class OddEvenSum
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            int numberEven = 0;
            int numberOdd = 0;
            for (int i = 0; i < loop; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0) { numberEven += number; }
                else { numberOdd += number; }

            }
            if (numberEven == numberOdd) { Console.WriteLine($"Yes"); Console.WriteLine($"Sum = {numberOdd}"); }
            else { Console.WriteLine($"No"); Console.WriteLine($"Diff = {Math.Abs(numberOdd - numberEven)}"); }
        }
    }
}
