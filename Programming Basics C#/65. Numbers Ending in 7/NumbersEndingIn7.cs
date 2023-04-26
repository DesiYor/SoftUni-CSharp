/*
 ⦁	Числа до 1000, завършващи на 7
Напишете програма, която отпечатва числата в диапазона от 1 до 1000, които завършват на 7.

 */

using System;


namespace _65.Numbers_Ending_in_7
{
    internal class NumbersEndingIn7
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 1000; i++)
            {
                if (i % 10 == 7) { Console.WriteLine(i); }
            }
        }
    }
}
