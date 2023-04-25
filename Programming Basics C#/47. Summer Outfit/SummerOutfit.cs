/*
 Лятно облекло
Лято е с много променливо време и Виктор има нужда от вашата помощ. Напишете програма която спрямо времето от денонощието
и градусите да препоръча на Виктор какви дрехи да си облече. 
Вашия приятел има различни планове за всеки етап от деня, които изискват и различен външен вид,
тях може да видите от таблицата.
От конзолата се четат точно два реда:
⦁	Градусите - цяло число в интервала [10…42]
⦁	Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening"

!!!!! Таблицата е в файла със задачи -> https://github.com/DimitarZhelyazkov/SoftUni-CSharp/blob/SoftUni/Programming%20Basics%20C%23/01.%20Cinema_%D0%A3%D1%81%D0%BB%D0%BE%D0%B2%D0%B8%D1%8F.docx

Да се отпечата на конзолата на един ред: "It's {градуси} degrees, get your {облекло} and {обувки}."

 */

using System;


namespace _47.Summer_Outfit
{
    internal class SummerOutfit
    {
        static void Main(string[] args)
        {
            int deg = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            string shoes = null;
            string outfit = null;
            switch (dayTime)
            {
                case "Morning": 
                    if ( deg >= 10 && deg <= 18) { shoes = "Sneakers"; outfit = "Sweatshirt"; }
                    else if (deg > 18 && deg <= 24) { shoes = "Moccasins"; outfit = "Shirt"; }
                    else if (deg > 24) { shoes = "Sandals"; outfit = "T-Shirt"; }
                    else { break; }
                    break;
                case "Afternoon":
                    if (deg >= 10 && deg <= 18) { shoes = "Moccasins"; outfit = "Shirt"; }
                    else if (deg > 18 && deg <= 24) { shoes = "Sandals"; outfit = "T-Shirt"; }
                    else if (deg > 24) { shoes = "Barefoot"; outfit = "Swim Suit"; }
                    else { break; }
                    break;
                case "Evening":
                    if (deg >= 10) { shoes = "Moccasins"; outfit = "Shirt"; }
                    else { break; }
                    break;
                default: break;
            }
            if (shoes != null && outfit != null) { Console.WriteLine($"It's {deg} degrees, get your {outfit} and {shoes}."); }
        }
    }
}
