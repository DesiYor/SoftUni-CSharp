/*
 ⦁	Сумиране на числа
Да се напише програма, която чете n-на брой цели числа, въведени от потребителя и ги сумира.
⦁	От първия ред на входа се въвежда броят числа n.
⦁	От следващите n реда се въвежда по едно цяло число.
Програмата трябва да прочете числата, да ги сумира и да отпечата сумата им
 
 */


using System;


namespace _61.Sum_Numbers
{
    internal class SumNumbers
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            int number = 0;
            for(int i = 0; i < loop; i++)
            {
                number += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(number);
        }
    }
}
