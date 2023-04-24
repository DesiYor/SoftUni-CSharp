/*
 ⦁	Магазин за детски играчки
Петя има магазин за детски играчки. Тя получава голяма поръчка, която трябва да изпълни. С парите, които ще спечели
иска да отиде на екскурзия. 
Цени на играчките:
⦁	Пъзел - 2.60 лв.
⦁	Говореща кукла - 3 лв.
⦁	Плюшено мече - 4.10 лв.
⦁	Миньон - 8.20 лв.
⦁	Камионче - 2 лв.
Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25% от общата цена. 
От спечелените пари Петя трябва да даде 10% за наема на магазина. 
Да се пресметне дали парите ще ѝ стигнат да отиде на екскурзия.

Вход
От конзолата се четат 6 реда:
⦁	Цена на екскурзията - реално число в интервала [1.00 … 10000.00]
⦁	Брой пъзели - цяло число в интервала [0… 1000]
⦁	Брой говорещи кукли - цяло число в интервала [0 … 1000]
⦁	Брой плюшени мечета - цяло число в интервала [0 … 1000]
⦁	Брой миньони - цяло число в интервала [0 … 1000]
⦁	Брой камиончета - цяло число в интервала [0 … 1000]
Изход
На конзолата се отпечатва:
⦁	Ако парите са достатъчни се отпечатва:
⦁	"Yes! {оставащите пари} lv left."
⦁	Ако парите НЕ са достатъчни се отпечатва:
⦁	"Not enough money! {недостигащите пари} lv needed."

Резултатът трябва да се форматира до втория знак след десетичната запетая.

 */

using System;


namespace _29.Toy_Shop
{
    internal class ToyShop
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int tedyBear = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());   
            int tracks = int.Parse(Console.ReadLine());

            double purchases = puzle * 2.60 + doll * 3.00 + tedyBear * 4.10 + minions * 8.20 + tracks * 2.00;

            if (puzle + doll + tedyBear + minions + tracks >= 50) 
            {
                purchases -= purchases * 0.25; 
            }
            if (purchases * (1 - 0.1) >= vacationPrice) 
            {
                Console.WriteLine($"Yes! {(purchases * (1 - 0.1)) - vacationPrice:f2} lv left.");
            }
            else if (purchases * (1 - 0.1) < vacationPrice)
            {
                Console.WriteLine($"Not enough money! {vacationPrice - (purchases * (1 - 0.1)):f2} lv needed.");
            }
        }
    }
}
