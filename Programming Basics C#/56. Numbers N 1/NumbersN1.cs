/*
 ⦁	Числата от N до 1 в обратен ред
Напишете програма, която чете цяло положително число n, въведено от потребителя и печата числата от n до 1 в обратен ред.
Въведеното число n, винаги ще бъде по-голямо от 1.

 */

using System;

namespace _56.Numbers_N_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
