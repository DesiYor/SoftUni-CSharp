/*
 ⦁	Часовник
Напишете програма, която отпечатва часовете в денонощието от 0:0 до 23:59, всеки на отделен ред. Часовете трябва да се изписват във формат "{час}:{минути}".

 
 */

using System;


namespace _88.Clock
{
    internal class Clock
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 24; i++)
            {
                for(int a = 0; a < 60; a++)
                {
                    Console.WriteLine($"{i}:{a:00}");
                }
            }
        }
    }
}
