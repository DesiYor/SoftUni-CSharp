﻿/*
 ⦁	Число от 100 до 200
Да се напише програма, която чете цяло число, въведено от потребителя и проверява дали е под 100, между 100 и 200 или над 200. Ако числото е:
⦁	под 100 отпечатайте: "Less than 100"
⦁	между 100 и 200 отпечатайте: "Between 100 and 200"
⦁	над 200 отпечатайте: "Greater than 200"

 */

using System;


namespace _23.Number_100_to_200
{
    internal class Number100to200
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 100) { Console.WriteLine("Less than 100"); }
            else if (a >= 100 && a <= 200 ) { Console.WriteLine("Between 100 and 200"); }
            else if (a > 200) { Console.WriteLine("Greater than 200"); }
        }
    }
}
