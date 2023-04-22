/* 
 *  Напишете програма, която изчислява каква сума ще получите в края на депозитния период при определен лихвен процент.
 *  Използвайте следната формула: 
    сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
    Вход
    От конзолата се четат 3 реда:
    ⦁	Депозирана сума – реално число в интервала [100.00 … 10000.00]
    ⦁	Срок на депозита (в месеци) – цяло число в интервала [1…12]
    ⦁	Годишен лихвен процент – реално число в интервала [0.00 …100.00]
*/


using System;


namespace _3.Deposit_Calculator
{

    internal class DepositCalculator
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine()); 
            double interest = double.Parse(Console.ReadLine()) / 100; 

            double result = sum + months * ((sum * interest) /12);

            Console.WriteLine(result);
        }
    }
}
