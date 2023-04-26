/*
 ⦁	Редица цели числа
Напишете програма, която чете n на брой цели числа. Принтирайте най-голямото и най-малкото число сред въведените.
 */

using System;


namespace _62.Number_sequence
{
    internal class NumberSequence
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            int numberMin = 0;
            int numberMax = 0;
            int number = 0;
            for (int i = 0; i < loop; i++)
            {
                number = int.Parse(Console.ReadLine());
                if(i == 0) { numberMin = numberMax = number; }
                if (number > numberMax) { numberMax = number; }
                if (number < numberMin) { numberMin = number; }
            }
            Console.WriteLine($"Max number: {numberMax}");
            Console.WriteLine($"Min number: {numberMin}");
        }
    }
}
