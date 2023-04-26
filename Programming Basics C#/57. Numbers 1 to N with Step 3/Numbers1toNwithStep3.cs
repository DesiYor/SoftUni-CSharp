/*
 ⦁	Числата от 1 до N през 3
Напишете програма, която чете число n, въведено от потребителя и отпечатва числата от 1 до n през 3.

 */

using System;


namespace _57.Numbers_1_to_N_with_Step_3
{
    internal class Numbers1toNwithStep3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
