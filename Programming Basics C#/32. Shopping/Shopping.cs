﻿/*
 ⦁	Пазаруване 
Петър иска да купи N видеокарти, M процесора и P на брой рам памет. Ако броя на видеокартите е по-голям
от този на процесорите получава 15% отстъпка от крайната сметка. Важат следните цени:
⦁	Видеокарта – 250 лв./бр.
⦁	Процесор – 35% от цената на закупените видеокарти/бр.
⦁	Рам памет – 10% от цената на закупените видеокарти/бр.
Да се изчисли нужната сума за закупуване на материалите и да се пресметне дали бюджета ще му стигне.
Вход
Входът се състои от четири реда:
⦁	Бюджетът на Петър - реално число в интервала [0.0…100000.0]
⦁	Броят видеокарти - цяло число в интервала [0…100]
⦁	Броят процесори - цяло число в интервала [0…100]
⦁	Броят рам памет - цяло число в интервала [0…100]
Изход
На конзолата се отпечатва 1 ред, който трябва да изглежда по следния начин:
⦁	Ако бюджета е достатъчен:
"You have {остатъчен бюджет} leva left!"
⦁	Ако сумата надхвърля бюджета:
"Not enough money! You need {нужна сума} leva more!"
Резултатът да се форматира до втория знак след десетичната запетая.

 */

using System;


namespace _32.Shopping
{
    internal class Shopping
    {
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine()); // Бюджет
            double n = double.Parse(Console.ReadLine()); // видео карти
            double m = double.Parse(Console.ReadLine()); // процесори
            double p = double.Parse(Console.ReadLine()); // рам памети
            double total = (n * 250) + ( m * (n * 250 * 0.35)) + (p * (n * 250 * 0.1));
            if (n > m ) { total -= total * 0.15; }
            if (b >= total) { Console.WriteLine($"You have {b-total:f2} leva left!"); }
            else { Console.WriteLine($"Not enough money! You need {total-b:f2} leva more!"); }
        }
    }
}