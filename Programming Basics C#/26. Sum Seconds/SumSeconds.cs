/*
 ⦁	Сумиране на секунди 
Трима спортни състезатели финишират за някакъв брой секунди (между 1 и 50). Да се напише програма, която чете времената
на състезателите в секунди, въведени от потребителя и пресмята сумарното им време във формат "минути:секунди". 
Секундите да се изведат с водеща нула (2  "02", 7  "07", 35  "35"). 

 */

using System;


namespace _26.Sum_Seconds
{
    internal class SumSeconds
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if ( ((a+b+c) % 60) <= 9 ) { Console.WriteLine($"{(a + b + c) / 60}:0{(a + b + c) % 60}"); }
                else { Console.WriteLine($"{(a + b + c) / 60}:{(a + b + c) % 60}"); }
        }
    }
}
