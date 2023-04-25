/*
 ⦁	Кино
В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони.
Има три вида прожекции с билети на различни цени:
⦁	Premiere – премиерна прожекция, на цена 12.00 лева.
⦁	Normal – стандартна прожекция, на цена 7.50 лева.
⦁	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
Напишете програма, която чете тип прожекция (стринг), брой редове и брой колони в залата (цели числа), въведени от потребителя,
и изчислява общите приходи от билети при пълна зала. Резултатът да се отпечата във формат като в примерите по-долу,
с 2 знака след десетичната точка.  

 */

using System;

namespace _46.Cinema
{
    internal class Cinema
    {
        static void Main(string[] args)
        {
            string typeP = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            switch (typeP)
            {
                case "Premiere": Console.WriteLine($"{r * c * 12.00:f2} leva"); break;
                case "Normal": Console.WriteLine($"{r*c*7.50:f2} leva"); break;
                case "Discount": Console.WriteLine($"{r*c*5.00:f2} leva"); break;
                default: break;
            }
        }
    }
}
