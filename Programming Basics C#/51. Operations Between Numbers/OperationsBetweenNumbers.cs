/*
 ⦁	Операции между числа
Напишете програма, която чете две цели числа (N1 и N2) и оператор, с който да се извърши дадена математическа операция с тях.
Възможните операции са: Събиране(+), Изваждане(-), Умножение(*), Деление(/) и Модулно деление(%).
При събиране, изваждане и умножение на конзолата трябва да се отпечатат резултата и дали той е четен или нечетен.
При обикновеното деление – резултата. При модулното деление – остатъка.
Трябва да се има предвид, че делителят може да е равен на 0(нула), а на нула не се дели. В този случай трябва да се отпечата специално съобщениe.
Вход
От конзолата се прочитат 3 реда, въведени от потребителя:
⦁	N1 – цяло число в интервала [0...40 000]
⦁	N2 – цяло число в интервала [0...40 000]
⦁	Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“
Изход
Да се отпечата на конзолата един ред:
⦁	Ако операцията е деление:
⦁	"{N1} / {N2} = {резултат}" – резултатът е форматиран до вторият знак след дес.запетая
⦁	Ако операцията е модулно деление: 
⦁	"{N1} % {N2} = {остатък}"
⦁	В случай на деление с 0 (нула): 
⦁	"Cannot divide {N1} by zero"
 */

using System;


namespace _51.Operations_Between_Numbers
{
    internal class OperationsBetweenNumbers
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char o = char.Parse(Console.ReadLine());
            string type = null;
            if (n2 == 0 && (o == '/' || o == '%')) { Console.WriteLine($"Cannot divide {n1} by zero"); }
            else
            {
                switch (o)
                {
                    case '/': Console.WriteLine($"{n1} / {n2} = {(double)(n1) / (double)(n2):f2}"); break;
                    case '-':
                        if ((n1 - n2) % 2 == 0) { type = "even"; } else { type = "odd"; }
                        Console.WriteLine($"{n1} - {n2} = {n1 - n2} - {type}"); break;
                    case '+':
                        if ((n1 + n2) % 2 == 0) { type = "even"; } else { type = "odd"; }
                        Console.WriteLine($"{n1} + {n2} = {n1 + n2} - {type}"); break;
                    case '*':
                        if ((n1 * n2) % 2 == 0) { type = "even"; } else { type = "odd"; }
                        Console.WriteLine($"{n1} * {n2} = {n1 * n2} - {type}"); break;
                    case '%': Console.WriteLine($"{n1} % {n2} = {n1 % n2}"); break;
                    default: break;
                }
            }
        }
    }
}
