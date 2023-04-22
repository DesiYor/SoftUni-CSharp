/*
 ⦁	Пресмятане на лице на правоъгълник
Да се напише конзолна програма, която въвежда две цели числа (страните на правоъгълника a и b) 
и пресмята лицето на правоъгълник с тези страни.
 */

using System;


namespace _12.Rectangle_Area
{
    internal class RectangleArea
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x * y);
        }
    }
}
