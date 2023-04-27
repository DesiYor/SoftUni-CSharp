/*
 ⦁	Баланс по сметка
Напишете програма, която пресмята колко общо пари има в сметката, след като направите определен брой вноски.
На всеки ред ще получавате сумата, която трябва да внесете в сметката, до получаване на команда "NoMoreMoney" . 
При всяка получена сума на конзолата трябва да се извежда "Increase: " + сумата и тя да се прибавя в сметката.
Ако получите число по-малко от 0 на конзолата трябва да се изведе "Invalid operation!" и програмата да приключи. 
Когато програмата приключи трябва да се принтира "Total: " + общата сума в сметката форматирана до втория знак след десетичната запетая. 

 */

using System;


namespace _77.Account_Balance
{
    internal class AccountBalance
    {
        static void Main(string[] args)
        {
            string noMoney = "NoMoreMoney";
            string money = Console.ReadLine();
            double balans = 0;
            while (noMoney != money)
            {
                if (double.Parse(money) >= 0)
                {
                    balans += double.Parse(money);
                    Console.WriteLine($"Increase: {double.Parse(money):f2}");
                    money = Console.ReadLine();
                } else { Console.WriteLine("Invalid operation!"); break; }
            }
            Console.WriteLine($"Total: {balans:f2}");
        }
    }
}
