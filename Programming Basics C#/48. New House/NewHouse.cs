/*
 ⦁	Нов дом
Марин и Нели си купуват къща не далеч от София. Нели толкова много обича цветята, че Ви убеждава да напишете програма
която да изчисли колко  ще им струва, да си засадят определен брой цветя и дали наличния бюджет ще им е достатъчен.
Различните цветя са с различни цени. 
цвете	                 Роза	Далия	Лале	Нарцис	Гладиола
Цена на брой в лева 	 5	    3.80	2.80	3	    2.50
Съществуват следните отстъпки:
⦁	Ако Нели купи повече от 80 Рози - 10% отстъпка от крайната цена
⦁	Ако Нели купи повече от 90  Далии - 15% отстъпка от крайната цена
⦁	Ако Нели купи повече от 80 Лалета - 15% отстъпка от крайната цена
⦁	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15%
⦁	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20%
От конзолата се четат 3 реда:
⦁	Вид цветя - текст с възможности - "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
⦁	Брой цветя - цяло число в интервала [10…1000]
⦁	Бюджет - цяло число в интервала [50…2500]
Да се отпечата на конзолата на един ред:
⦁	Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
⦁	Ако бюджета им е НЕ достатъчен - "Not enough money, you need {нужната сума} leva more."
Сумата да бъде форматирана до втория знак след десетичната запетая.

 */

using System;


namespace _48.New_House
{
    internal class NewHouse
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double total = 0;
            switch (flowers)
            {
                case "Roses": 
                    if (amount > 80) { total = (amount * 5) * (1 - 0.10); }
                    else { total = amount * 5; }
                    break;
                case "Dahlias":
                    if (amount > 90) { total = (amount * 3.80) * (1 - 0.15); }
                    else { total = amount * 3.80; }
                    break;
                case "Tulips":
                    if (amount > 80) { total = (amount * 2.80) * (1 - 0.15); }
                    else { total = amount * 2.80; }
                    break;
                case "Narcissus":
                    if (amount < 120) { total = (amount * 3) + ( amount * 3 * 0.15); }
                    else { total = amount * 3; }
                    break;
                case "Gladiolus":
                    if (amount < 80) { total = (amount * 2.50) + (amount * 2.50 * 0.20); }
                    else { total = amount * 2.50; }
                    break;
                default: break;
            }
            if (total <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {amount} {flowers} and {budget-total:f2} leva left.");
            }
            else { Console.WriteLine($"Not enough money, you need {total-budget:f2} leva more."); }
        }
    }
}
