/*
 ⦁	Информация за скоростта
Да се напише програма, която чете скорост (реално число), въведена от потребителя и отпечатва информация за скоростта. 
⦁	При скорост до 10 (включително) отпечатайте "slow"
⦁	При скорост над 10 и до 50 (включително) отпечатайте "average" 
⦁	При скорост над 50 и до 150 (включително) отпечатайте "fast"
⦁	При скорост над 150 и до 1000 (включително) отпечатайте "ultra fast" 
⦁	При по-висока скорост отпечатайте "extremely fast"
 */

using System;


namespace _24.Speed_Info
{
    internal class SpeedInfo
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            if (a <= 10 ) { Console.WriteLine("slow"); }
            else if (a > 10 && a <= 50) { Console.WriteLine("average"); }
            else if (a > 50 && a <= 150) { Console.WriteLine("fast"); }
            else if (a > 150 && a <= 1000) { Console.WriteLine("ultra fast"); }
            else { Console.WriteLine("extremely fast"); }
        }
    }
}
