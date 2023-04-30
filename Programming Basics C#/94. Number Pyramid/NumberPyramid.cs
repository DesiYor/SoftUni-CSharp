/*
 ⦁	Пирамида от числа
Напишете програма, която чете цяло число n, въведено от потребителя, и отпечатва пирамида от числа като в примерите:


 Във файла с задачи Number Pyramid условия
 */

using System;


namespace _94.Number_Pyramid
{
    internal class NumberPyramid
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 1; i <= number && count != number; i++)
            {
                for(int j = 1; j <= i && count != number; j++)
                {
                    count++;
                    Console.Write(count + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
