/*
 ⦁	Редица числа 2k + 1
Напишете програма, която чете число n, въведено от потребителя, и отпечатва всички числа ≤ n от редицата: 1, 3, 7, 15, 31, …. 
Всяко следващо число се изчислява като умножим предишното с 2 и добавим 1.

 */

using System;


namespace _76.Sequence_2k_plus_1
{
    internal class Sequence2kPLus1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int j = 1;
            while (j <= n) 
            {
                Console.WriteLine(j);
                j = j * 2 + 1;
                
            }
        }
    }
}
