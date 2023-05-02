using System;


namespace _02.Skeleton
{
    internal class Skeleton
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double sec100 = double.Parse(Console.ReadLine());

            int time = min*60 + sec;
            double slow = (lenght / 120) * 2.5;
            double total = ((lenght / 100) * sec100) - slow;
            if(total <= time) { Console.WriteLine($"Marin Bangiev won an Olympic quota!"); Console.WriteLine($"His time is {total:f3}."); }
            else { Console.WriteLine($"No, Marin failed! He was {Math.Abs(total-time):f3} second slower."); }

        }
    }
}
