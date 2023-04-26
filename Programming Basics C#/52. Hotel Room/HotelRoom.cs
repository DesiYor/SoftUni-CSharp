/*
 ⦁	Хотелска стая
Хотел предлага 2 вида стаи: студио и апартамент. Напишете програма, която изчислява цената за целия престой за студио и апартамент.
Цените зависят от месеца на престоя:
    Май и октомври	                    Юни и септември	                  Юли и август
Студио – 50 лв./нощувка	        Студио – 75.20 лв./нощувка	        Студио – 76 лв./нощувка
Апартамент – 65 лв./нощувка 	Апартамент – 68.70 лв./нощувка	    Апартамент – 77 лв./нощувка

Предлагат се и следните отстъпки:
⦁	За студио, при повече от 7 нощувки през май и октомври : 5% намаление.
⦁	За студио, при повече от 14 нощувки през май и октомври : 30% намаление.
⦁	За студио, при повече от 14 нощувки през юни и септември: 20% намаление.
⦁	За апартамент, при повече от 14 нощувки, без значение от месеца : 10% намаление.
Вход
Входът се чете от конзолата и съдържа точно 2 реда, въведени от потребителя:
⦁	На първия ред е месецът – May, June, July, August, September или October
⦁	На втория ред е броят на нощувките – цяло число в интервала [0 ... 200]
Изход
Да се отпечатат на конзолата 2 реда:
⦁	На първия ред: “Apartment: {цена за целият престой} lv.”
⦁	На втория ред: “Studio: {цена за целият престой} lv.“
Цената за целия престой форматирана с точност до два знака след десетичната запетая.

 */

using System;

namespace _52.Hotel_Room
{
    internal class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double discountStudio = 0;
            double discountApp = 0;
            double priceApp = 0;
            double priceStudio = 0;
            if (nights > 14) { discountApp = 0.1; }
            switch (month)
            {
                case "May":
                case "October":
                    if (nights > 7 && nights < 14) { discountStudio = 0.05; }
                    if (nights >= 14) { discountStudio = 0.30; }
                    priceApp = 65;
                    priceStudio = 50;
                    break;
                case "June":
                case "September":
                    if (nights > 14) { discountStudio = 0.20; }
                    priceApp = 68.70;
                    priceStudio = 75.20;
                    break;
                case "July":
                case "August":
                    priceApp = 77;
                    priceStudio = 76;
                    break;
                default: break;
            }
            Console.WriteLine($"Apartment: {nights * priceApp * (1 - discountApp):f2} lv.");
            Console.WriteLine($"Studio: {nights * priceStudio * (1 - discountStudio):f2} lv.");
        }
    }
}
