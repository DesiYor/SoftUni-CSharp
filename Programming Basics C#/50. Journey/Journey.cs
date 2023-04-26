/*
 ⦁	Пътешествие
Странно, но повечето хора си плануват от рано почивката. Млад програмист разполага с определен бюджет и свободно време
в даден сезон. Напишете програма, която да приема на входа бюджета и сезона, 
а на изхода да изкарва, къде ще почива програмиста и колко ще похарчи.
Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи. 
Ако е лято ще почива на къмпинг, а зимата в хотел. Ако е в Европа, независимо от сезона ще почива в хотел.
Всеки къмпинг или хотел, според дестинацията, има собствена цена която отговаря на даден процент от бюджета: 
⦁	При 100лв. или по-малко – някъде в България
⦁	Лято – 30% от бюджета
⦁	Зима – 70% от бюджета
⦁	При 1000лв. или по малко – някъде на Балканите
⦁	Лято – 40% от бюджета
⦁	Зима – 80% от бюджета
⦁	При повече от 1000лв. – някъде из Европа
⦁	При пътуване из Европа, независимо от сезона ще похарчи 90% от бюджета.
Вход
Входът се чете от конзолата и се състои от два реда, въведени от потребителя:
⦁	Първи ред – Бюджет, реално число в интервала [10.00...5000.00].
⦁	Втори ред –  Един от двата възможни сезона: „summer” или “winter”
Изход
На конзолата трябва да се отпечатат два реда.
⦁	Първи ред – „Somewhere in [дестинация]“ измежду “Bulgaria", "Balkans” и ”Europe”
⦁	Втори ред – “{Вид почивка} – {Похарчена сума}“
⦁	Почивката може да е между „Camp” и „Hotel”
⦁	Сумата трябва да е закръглена с точност до вторият знак след запетаята.

 */

using System;


namespace _50.Journey
{
    internal class Journey
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = null;
            string type = null;
            if (budget <= 100) { place = "Bulgaria"; }
            else if (budget > 100 && budget <= 1000 ) { place = "Balkans"; }
            else { place = "Europe"; }
            switch(place)
            {
                case "Bulgaria": 
                    if (season == "summer") { type = "Camp"; budget = budget * 0.30;  }
                    else { type = "Hotel"; budget = budget * 0.70; }
                    break;
                case "Balkans":
                    if (season == "summer") { type = "Camp"; budget = budget * 0.40; }
                    else { type = "Hotel"; budget = budget * 0.80; }
                    break;
                case "Europe":
                    type = "Hotel"; budget = budget * 0.90; 
                    break;
                default: break;
            }
            if (type != null && place != null) {
                Console.WriteLine($"Somewhere in {place}");
                Console.WriteLine($"{type} - {budget:f2}");
            }
            Console.ReadLine();
        }
    }
}
