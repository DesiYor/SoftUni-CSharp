/*
 Елемент, равен на сумата на останалите
Да се напише програма, която чете n-на брой цели числа, въведени от потребителя,и проверява дали сред тях съществува число, 
което е равно на сумата на всички останали. 
⦁	Ако има такъв елемент печата "Yes" и на нов ред "Sum = "  + неговата стойност
⦁	Ако няма такъв елемент печата "No" и на нов ред "Diff = " + разликата между най-големия елемент и сумата на останалите (по абсолютна стойност)

 */

using System;


namespace _66.Half_Sum_Element
{
    internal class HalfSumElement
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            int numberMax = 0;
            int numberSum = 0;
            for (int i = 0; i < loop; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(i == 0) { numberMax = number; }
                if(numberMax < number) { numberMax = number; }
                numberSum += number;
            }
            if (numberSum - numberMax == numberMax) { Console.WriteLine("Yes"); Console.WriteLine($"Sum = {numberMax}"); }
            else { Console.WriteLine("No"); Console.WriteLine($"Diff = {Math.Abs(numberSum - numberMax * 2)}"); }
        }
    }
}
