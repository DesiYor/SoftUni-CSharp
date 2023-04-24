/*
 ⦁	Квартално магазинче
Предприемчив българин отваря квартални магазинчета в няколко града и продава на различни цени според града:
град / продукт	coffee	water	beer	sweets	peanuts
Sofia	        0.50	0.80	1.20	1.45	1.60
Plovdiv	        0.40	0.70	1.15	1.30	1.50
Varna	        0.45	0.70	1.10	1.35	1.55
Напишете програма, която чете продукт (низ), град (низ) и количество (десетично число),
въведени от потребителя, и пресмята и отпечатва колко струва съответното количество от избрания продукт в посочения град. 
 */

using System;


namespace _38.Small_Shop
{
    internal class SmallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            double total = 0;
            
            switch (product) 
            {
                case "coffee":
                    switch (town) {
                        case "Sofia": total = price * 0.5; break;
                        case "Plovdiv": total = price * 0.4; break;
                        case "Varna": total = price * 0.45; break;
                    } 
                    break;
                case "water":
                    switch (town)
                    {
                        case "Sofia": total = price * 0.8; break;
                        case "Plovdiv": total = price * 0.7; break;
                        case "Varna": total = price * 0.7; break;
                    }
                    break;
                case "beer":
                    switch (town)
                    {
                        case "Sofia": total = price * 1.20; break;
                        case "Plovdiv": total = price * 1.15; break;
                        case "Varna": total = price * 1.10; break;
                    }
                    break;
                case "sweets":
                    switch (town)
                    {
                        case "Sofia": total = price * 1.45; break;
                        case "Plovdiv": total = price * 1.30; break;
                        case "Varna": total = price * 1.35; break;
                    }
                    break;
                case "peanuts":
                    switch (town)
                    {
                        case "Sofia": total = price * 1.60; break;
                        case "Plovdiv": total = price * 1.50; break;
                        case "Varna": total = price * 1.55; break;
                    }
                    break;
            }
            Console.WriteLine(total);
        }
    }
}
