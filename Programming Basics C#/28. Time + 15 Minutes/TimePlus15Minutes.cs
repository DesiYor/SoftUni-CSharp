/*
 ⦁	Време + 15 минути
Да се напише програма, която чете час и минути от 24-часово денонощие, въведени от потребителя и изчислява
колко ще е часът след 15 минути. Резултатът да се отпечата във формат часове:минути. Часовете винаги са между 0 и 23,
а минутите винаги са между 0 и 59. Часовете се изписват с една или две цифри.
Минутите се изписват винаги с по две цифри, с водеща нула, когато е необходимо. 
 */

using System;


namespace _28.Time___15_Minutes
{
    internal class TimePlus15Minutes
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if( m >= 45 ) { h++; m = m - 45; }
                else { m += 15; }
            if (h > 23) { h -= 24; }
            if( m <= 9 ) { Console.WriteLine($"{h}:0{m}"); }
            else { Console.WriteLine($"{h}:{m}"); }
        }
    }
}
