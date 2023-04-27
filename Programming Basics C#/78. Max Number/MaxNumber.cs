/*
 ⦁	Най-голямо число
Напишете програма, която до получаване на командата "Stop", чете цели числа, въведени от потребителя и намира най-голямото измежду тях. 
Въвежда се по едно число на ред. 

 */

using System;


namespace _78.Max_Number
{
    internal class MaxNumber
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            while (true)
            {
                string number = Console.ReadLine();
                if(number == "Stop") { break; }
                else
                {
                    if(int.Parse(number) > max) { max = int.Parse(number); }
                }
            }
            Console.WriteLine(max);
        }
    }
}
