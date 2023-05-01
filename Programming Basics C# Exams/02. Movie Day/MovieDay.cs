/*Задача 2. Снимачен ден
Вие сте режисьор на филма "Програмирането е забавно", като имате определено време за снимки.
От вас се иска да напишете програма, с която ще разберете дали снимачният ден ще ви стигне да заснемете филма.
Снимачният ден започва с подготовка на терен, което е 15 процента от времето за снимки!
Филмът има определен брой сцени, които се заснемат за определено време.
Вход
От конзолата се четат 3 реда:
Време за снимки – цяло число в диапазона [0… 1440]
Брой сцени  – цяло число в диапазона [5… 25]
Времетраене на сцена – цяло число в диапазона [20… 90]
Изход
На конзолата да се отпечата един ред:
Ако времето за заснемане на филма ви стигне: 
  "You managed to finish the movie on time! You have {останало време} minutes left!"
Ако времето НЕ ВИ стигне:
  "Time is up! To complete the movie you need {нужно време} minutes."
Останалото време да се закръгли до най-близкото цяло число.
*/

using System;


namespace _02.Movie_Day
{
    internal class MovieDay 
    {
        static void Main(string[] args)
        {
            int timeToFilm = int.Parse(Console.ReadLine());
            int scene = int.Parse(Console.ReadLine());
            int timePerScene = int.Parse(Console.ReadLine());
            double gettingGeady = timeToFilm * 0.15;
            if (timeToFilm >= scene * timePerScene + gettingGeady)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeToFilm - (scene*timePerScene+gettingGeady))} minutes left!");
            }else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round((scene * timePerScene + gettingGeady) - timeToFilm)} minutes.");
            }
        }
    }
}
