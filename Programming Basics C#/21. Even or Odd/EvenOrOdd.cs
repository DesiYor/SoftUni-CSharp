/*
 ⦁	Четно или нечетно
Да се напише програма, която чете цяло число, въведено от потребителя, и печата дали е четно или нечетно. 
Ако е четно отпечатайте "even", ако е нечетно "odd".

 */


using System;


namespace _21.Even_or_Odd
{
    internal class EvenOrOdd
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) { Console.WriteLine("even"); }
                else { Console.WriteLine("odd"); }
        }
    }
}
