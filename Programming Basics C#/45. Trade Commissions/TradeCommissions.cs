/*
 * ⦁	Търговски комисионни
Фирма дава следните комисионни на търговците си според града, в който работят и обема на продажбите:
Град	0 ≤ s ≤ 500	    500 < s ≤ 1 000	    1 000 < s ≤ 10 000	    s > 10 000
Sofia	    5%	            7%	                8%	                    12%
Varna	    4.5%	        7.5%	            10%	                    13%
Plovdiv	    5.5%	        8%	                12%	                    14.5%
Напишете конзолна програма, която чете име на град (стринг) и обем на продажби (реално число) , въведени от потребителя, 
и изчислява и извежда размера на търговската комисионна според горната таблица.
Резултатът да се изведе форматиран до 2 цифри след десетичната точка.
При невалиден град или обем на продажбите (отрицателно число) да се отпечата "error". 
 * 
 */

using System;

namespace _45.Trade_Commissions
{
    internal class TradeCommissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            switch (town)
            {
                case "Sofia":
                    if ( sales >= 0 && sales <= 500 ) { Console.WriteLine($"{ sales * 0.05:f2}"); }
                    else if ( sales > 500 && sales <= 1000) { Console.WriteLine($"{sales * 0.07:f2}"); }
                    else if ( sales > 1000 && sales <= 10000) { Console.WriteLine($"{sales * 0.08:f2}"); }
                    else if (sales > 10000) { Console.WriteLine($"{sales * 0.12:f2}"); }
                    else { Console.WriteLine("error"); break; }
                    break;
                case "Varna":
                    if (sales >= 0 && sales <= 500) { Console.WriteLine($"{sales * 0.045:f2}"); }
                    else if (sales > 500 && sales <= 1000) { Console.WriteLine($"{sales * 0.075:f2}"); }
                    else if (sales > 1000 && sales <= 10000) { Console.WriteLine($"{sales * 0.1:f2}"); }
                    else if (sales > 10000) { Console.WriteLine($"{sales * 0.13:f2}"); }
                    else { Console.WriteLine("error"); break; }
                    break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500) { Console.WriteLine($"{sales * 0.055:f2}"); }
                    else if (sales > 500 && sales <= 1000) { Console.WriteLine($"{sales * 0.08:f2}"); }
                    else if (sales > 1000 && sales <= 10000) { Console.WriteLine($"{sales * 0.12:f2}"); }
                    else if (sales > 10000) { Console.WriteLine($"{sales * 0.145:f2}"); }
                    else { Console.WriteLine("error"); break; }
                    break;
                default: Console.WriteLine("error"); break;
            }
        }
    }
}
