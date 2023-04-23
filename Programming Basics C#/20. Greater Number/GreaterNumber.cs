/*
 ⦁	По-голямото число
Да се напише програма, която чете две цели числа въведени от потребителя и отпечатва по-голямото от двете
 */

using System;


namespace _20.Greater_Number
{
    internal class GreaterNumber
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b) { Console.WriteLine(a); }
                else { Console.WriteLine(b); }  
        }
    }
}
