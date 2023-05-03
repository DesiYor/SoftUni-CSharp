using System;


namespace _05.Tennis_Ranklist
{
    internal class TennisRanklist
    {
        static void Main(string[] args)
        {
            int games = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int countW = 0, points = 0;
            for (int i = 0; i < games; i++)
            {
                string etap = Console.ReadLine();
                switch (etap)
                {
                    case "W": points += 2000; countW++;  break;
                    case "F": points += 1200;  break;
                    case "SF": points += 720;  break;
                    default: break;
                }
            }
            Console.WriteLine($"Final points: {startPoints+points}");
            Console.WriteLine($"Average points: {points/games}");
            Console.WriteLine($"{(double)countW/games*100:f2}%");
        }
    }
}
