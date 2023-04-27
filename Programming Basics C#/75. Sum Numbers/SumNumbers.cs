/*
 ⦁	Сума от числа
Напишете програма, която чете цяло число от конзолата и на всеки следващ ред цели числа,
докато тяхната сума стане по-голяма или равна на първоначалното число.
След приключване да се отпечата сумата на въведените числа.

 */

using System;


namespace _75.Sum_Numbers
{
    internal class SumNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (sum < number)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
