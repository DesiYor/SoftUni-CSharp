/*
 ⦁	Годзила срещу Конг
Снимките за дългоочаквания филм "Годзила срещу Конг" започват. Сценаристът Адам Уингард ви моли да напишете програма,
която да изчисли, дали предвидените средства са достатъчни за снимането на филма.
За снимките  ще бъдат нужни определен брой статисти, облекло за всеки един статист и декор.
Известно е, че:
⦁	Декорът за филма е на стойност 10% от бюджета. 
⦁	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10%.
Вход
От конзолата се четат 3 реда:     
⦁	Бюджет за филма – реално число в интервала [1.00 … 1000000.00]
⦁	Брой на статистите – цяло число в интервала [1 … 500]
⦁	Цена за облекло на един статист – реално число в интервала [1.00 … 1000.00]
Изход
На конзолата трябва да се отпечатат два реда:
⦁	Ако  парите за декора и дрехите са повече от бюджета:
⦁	"Not enough money!"
⦁	"Wingard needs {парите недостигащи за филма} leva more."
⦁	Ако парите за декора и дрехите са по малко или равни на бюджета:
⦁	"Action!" 
⦁	"Wingard starts filming with {останалите пари} leva left."
Резултатът трябва да е форматиран до втория знак след десетичната запетая.

 */


using System;


namespace _30.Godzilla_vs_Kong
{
    internal class GodzillaVsKong
    {
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());
            int ppl = int.Parse(Console.ReadLine());
            double pEquip = double.Parse(Console.ReadLine());
            double dek = b * 0.1;
            double total = ppl * pEquip + dek;
            if (ppl >= 150 ) { total = ppl * (pEquip * (1 - 0.1)) + dek; }
            if (total > b) 
            { 
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {total-b:f2} leva more.");
            }
            else
            { 
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {b-total:f2} leva left.");
            }
        }
    }
}
