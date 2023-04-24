/*
 Обедна почивка
По време на обедната почивка искате да изгледате епизод от своя любим сериал.
Вашата задача е да напишете програма, с която ще разберете дали имате достатъчно време да изгледате епизода.
По време на почивката отделяте време за обяд и време за отдих. Времето за обяд ще бъде 1/8 от времето за почивка,
а времето за отдих ще бъде 1/4 от времето за почивка. 
Вход
От конзолата се четат 3 реда:
⦁	Име на сериал – текст
⦁	Продължителност на епизод  – цяло число в диапазона [10… 90]
⦁	Продължителност на почивката  – цяло число в диапазона [10… 120]
Изход
На конзолата да се изпише един ред:
⦁	Ако времето е достатъчно да изгледате епизода: 
"You have enough time to watch {име на сериал} and left with {останало време} minutes free time."
⦁	Ако времето не Ви е достатъчно:
"You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."
Времето да се закръгли до най-близкото цяло число нагоре.

 */

using System;


namespace _33.Lunch_Break
{
    internal class LunchBreak
    {
        static void Main(string[] args)
        {
            string nameSeries = Console.ReadLine();
            int epizodeTime = int.Parse(Console.ReadLine());
            double breakTime = int.Parse(Console.ReadLine());
            double timeToWatch = breakTime - (breakTime / 8) - (breakTime / 4);
            int round = 0; // Допулнитела променлива която да съхранява закръглянто с + 1 при остатук
            if (Math.Abs(timeToWatch - epizodeTime) % 1 > 0 ) { round++; }
            if (timeToWatch >= epizodeTime) 
            {
                Console.WriteLine($"You have enough time to watch {nameSeries} " +
                    $"and left with {(int)(timeToWatch-epizodeTime+round)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameSeries}, " +
                    $"you need {(int)(epizodeTime-timeToWatch+round)} more minutes.");
            }
        }
    }
}
