/*
 ⦁	Магазин за плодове
Магазин за плодове през работните дни работи на следните цени:
плод	banana	apple	orange	grapefruit	kiwi	pineapple	grapes
цена	2.50	1.20	0.85	1.45	    2.70	5.50	    3.85
Събота и неделя магазинът работи на по-високи цени:
плод	banana	apple	orange	grapefruit	kiwi	pineapple	grapes
цена	2.70	1.25	0.90	1.60	    3.00	5.60	    4.20
Напишете програма, която чете от конзолата плод (banana / apple / orange / grapefruit / kiwi / pineapple / grapes),
ден от седмицата (Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) и количество (реално число) ,
въведени от потребителя, и пресмята цената според цените от таблиците по-горе.
Резултатът да се отпечата закръглен с 2 цифри след десетичната точка.
При невалиден ден от седмицата или невалидно име на плод да се отпечата "error". 

 */

using System;


namespace _44.Fruit_Shop
{
    internal class FruitShop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double total = double.Parse(Console.ReadLine());
            if ( day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana": Console.WriteLine($"{total * 2.50:f2}");break;
                    case "apple": Console.WriteLine($"{total * 1.20:f2}");break;
                    case "orange": Console.WriteLine($"{total * 0.85:f2}");break;
                    case "grapefruit": Console.WriteLine($"{total * 1.45:f2}");break;
                    case "kiwi": Console.WriteLine($"{total * 2.70:f2}");break;
                    case "pineapple": Console.WriteLine($"{total * 5.50:f2}");break;
                    case "grapes": Console.WriteLine($"{total * 3.85:f2}");break;
                    default: Console.WriteLine("error"); break;
                }
            } else if ( day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana": Console.WriteLine($"{total * 2.70:f2}"); break;
                    case "apple": Console.WriteLine($"{total * 1.25:f2}"); break;
                    case "orange": Console.WriteLine($"{total * 0.90:f2}"); break;
                    case "grapefruit": Console.WriteLine($"{total * 1.60:f2}"); break;
                    case "kiwi": Console.WriteLine($"{total * 3.00:f2}"); break;
                    case "pineapple": Console.WriteLine($"{total * 5.60:f2}"); break;
                    case "grapes": Console.WriteLine($"{total * 4.20:f2}"); break;
                    default: Console.WriteLine("error"); break;
                }
            } else { Console.WriteLine("error"); }
        }
    }
}
