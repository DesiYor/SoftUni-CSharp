/*
 ⦁	Комбинации
Напишете програма, която изчислява колко решения в естествените числа (включително и нулата) има уравнението:
x1 + x2 + x3 = n
Числото n е цяло число и се въвежда от конзолата. 
 */

using System;

namespace _90.Combinations
{
    internal class Combinations
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i <= n; i++)
            {
                for(int j = 0; j <= n; j++)
                {
                    for(int k = 0; k <= n; k++)
                    {
                        if( i + j + k == n) { count++; }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
