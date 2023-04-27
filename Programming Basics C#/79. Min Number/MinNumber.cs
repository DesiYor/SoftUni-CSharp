/*
 ⦁	Най-малко число
Напишете програма, която до получаване на командата "Stop", чете цели числа, въведени от потребителя и намира най-малкото измежду тях.
Въвежда се по едно число на ред. 

 */

using System;


namespace _79.Min_Number
{
    internal class MinNumber
    {
        static void Main(string[] args)
        {
            int max = int.MaxValue;
            while (true)
            {
                string number = Console.ReadLine();
                if (number == "Stop") { break; }
                else
                {
                    if (int.Parse(number) < max) { max = int.Parse(number); }
                }
            }
            Console.WriteLine(max);
        }
    }
}
