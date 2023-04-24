/*
 ⦁	Число в интервалa
Да се напише програма, която проверява дали въведеното от потребителя число е в интервала [-100, 100]
и е различно от 0 и извежда "Yes", ако отговаря на условията, или "No" ако е извън тях.

 */

using System;


namespace _39.Number_in_Range
{
    internal class NumberInRange
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            if (a >= -100 && a!=0 && a <= 100 ) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }
    }
}
