/*
    ⦁	Пребоядисване
Румен иска да пребоядиса хола и за целта е наел майстори. Напишете програма, която изчислява разходите за ремонта,
предвид следните цени:
⦁	Предпазен найлон - 1.50 лв. за кв. метър
⦁	Боя - 14.50 лв. за литър
⦁	Разредител за боя - 5.00 лв. за литър
За всеки случай, към необходимите материали, Румен иска да добави още 10% от количеството боя и 2 кв.м. найлон,
разбира се и 0.40 лв. за торбички. Сумата, която се заплаща на майсторите за 1 час работа, е равна на 30% от сбора на
всички разходи за материали.
Вход
Входът се чете от конзолата и съдържа точно 4 реда:
⦁	Необходимо количество найлон (в кв.м.) - цяло число в интервала [1... 100]
⦁	Необходимо количество боя (в литри) - цяло число в интервала [1…100]
⦁	Количество разредител (в литри) - цяло число в интервала [1…30]
⦁	Часовете, за които майсторите ще свършат работата - цяло число в интервала [1…9]
Изход
Да се отпечата на конзолата един ред:
⦁	"{сумата на всички разходи}"

 */


using System;


namespace _6.Repainting
{
    internal class Repainting
    {
        static void Main(string[] args)
        {
            double foilPrice = (int.Parse(Console.ReadLine()) + 2) * 1.50;
            double paintPrice = int.Parse(Console.ReadLine()) * 14.50;
            double paintThinnerPrice = int.Parse(Console.ReadLine()) * 5.00;
            double extraPricePaint = paintPrice * 0.10 + 0.40;
            double workPrice = int.Parse(Console.ReadLine()) * ((foilPrice + paintPrice + paintThinnerPrice + extraPricePaint) * 0.30 );
            Console.WriteLine("{" + (foilPrice + paintThinnerPrice + extraPricePaint + paintPrice + workPrice).ToString() + "}");
            Console.ReadLine();
        }
    }
}
