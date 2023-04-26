/*
 ⦁	Лодка за риболов
Тони и приятели много обичали да ходят за риба, те са толкова запалени по риболова, че решават да отидат на риболов с кораб.
Цената за наема на кораба зависи от сезона и броя рибари.
Цената зависи от сезона:
⦁	Цената за наем на кораба през пролетта е  3000 лв.
⦁	Цената за наем на кораба през лятото и есента е  4200 лв.
⦁	Цената за наем на кораба през зимата е  2600 лв.
В зависимост от броя си групата ползва отстъпка:
⦁	Ако групата е до 6 човека включително  –  отстъпка от 10%.
⦁	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15%.
⦁	Ако групата е от 12 нагоре  –  отстъпка от 25%. 
Рибарите ползват допълнително 5% отстъпка, ако са четен брой освен ако не е есен - тогава нямат допълнителна отстъпка,
която се начислява след като се приспадне отстъпката по горните критерии.
Напишете програма, която да пресмята дали рибарите ще съберат достатъчно пари. 
Вход
От конзолата се четат точно три реда.
⦁	Бюджет на групата – цяло число в интервала [1…8000]
⦁	Сезон –  текст: "Spring", "Summer", "Autumn", "Winter"
⦁	Брой рибари – цяло число в интервала [4…18]
Изход
Да се отпечата на конзолата един ред:
⦁	Ако бюджетът е достатъчен:
"Yes! You have {останалите пари} leva left."
⦁	Ако бюджетът НЕ Е достатъчен:
"Not enough money! You need {сумата, която не достига} leva."
Сумите трябва да са форматирани с точност до два знака след десетичната запетая.

 */

using System;


namespace _49.Fishing_Boat
{
    internal class FishingBoat
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherMans = int.Parse(Console.ReadLine());
            double total = 0;
            double discount = 0;
            if (fisherMans <= 6) { discount = 0.1; }
            else if (fisherMans >= 7 && fisherMans <= 11) { discount = 0.15; }
            else { discount = 0.25; }
            switch (season)
            {
                case "Spring":
                    total = 3000 * (1 - discount);
                    break;
                case "Summer": case "Autumn": //И двете да еднакви като изход 
                    total = 4200 * (1 - discount);
                    break;
                case "Winter":
                    total = 2600 * (1 - discount);
                    break;
                default: break;
            }
            if(fisherMans % 2 == 0 && season != "Autumn") { total = total * (1 - 0.05); }
            if (total <= budget) { Console.WriteLine($"Yes! You have {budget - total:f2} leva left."); }
            else { Console.WriteLine($"Not enough money! You need {total - budget:f2} leva."); }
        }
    }
}
