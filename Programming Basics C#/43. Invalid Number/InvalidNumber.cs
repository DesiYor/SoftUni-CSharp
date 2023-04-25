/*
 ⦁	Невалидно число
Дадено число е валидно, ако е в диапазона [100…200] или е 0. Да се напише програма, която чете цяло число,
въведено от потребителя, и печата "invalid" ако въведеното число не е валидно. 
 */

using System;


namespace _43.Invalid_Number
{
    internal class InvalidNumber
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (!(a >= 100 && a <= 200) && a != 0)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
