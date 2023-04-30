/*
 ⦁	Суми прости и непрости числа
Напишете програма, която чете от конзолата цели числа в диапазона, докато не се получи команда "stop".
Да се намери сумата на всички въведени прости и сумата на всички въведени непрости числа.
Тъй като по дефиниция от математиката отрицателните числа не могат да бъдат прости, 
ако на входа се подаде отрицателно число да се изведе следното съобщение "Number is negative.". 
В този случай въведено число се игнорира и не се прибавя към нито една от двете суми,
а програмата продължава своето изпълнение, очаквайки въвеждане на следващо число. 
На изхода да се отпечатат на два реда двете намерени суми в следния формат:
⦁	"Sum of all prime numbers is: {prime numbers sum}"
⦁	"Sum of all non prime numbers is: {nonprime numbers sum}"

 
 */

using System;


namespace _96.Sum_Prime_Non_Prime
{
    internal class SumPrimeNonPrime
    {
        static void Main(string[] args)
        {
            string number = "";
            int num, prime = 0, nonprime = 0, count;
            while (true)
            {
                number = Console.ReadLine();
                if (number == "stop") break;
                num = int.Parse(number);
                if (num < 0) { Console.WriteLine($"Number is negative."); }
                else
                {
                    count = 0;
                    for (int i = 2; i <= num; i++)
                    {
                        if (num % i == 0) count++;
                    }
                    if (count <= 1) prime += num;
                    else nonprime += num;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonprime}");
        }
    }
}
