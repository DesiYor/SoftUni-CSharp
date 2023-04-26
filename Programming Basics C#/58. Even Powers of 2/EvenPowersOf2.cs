/*
 ⦁	Четни степени на 2
Да се напише програма, която чете число n, въведено от потребителя, и печата четните степени на 2 ≤ 2n: 20, 22, 24, 26, …, 2n. 
 */

using System;


namespace _58.Even_Powers_of_2
{
    internal class EvenPowersOf2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i <= n; i+=2) 
            {
                Console.WriteLine(Math.Pow(2,i));
            }
        }
    }
}
