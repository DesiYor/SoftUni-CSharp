using System;
using System.Reflection;


namespace _06.Basketball_Tournament
{
    internal class BasketballTournament
    {
        static void Main(string[] args)
        {
            int countWin = 0, countLoss = 0;
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "End of tournaments") { break; }
                int games = int.Parse(Console.ReadLine());
                for (int i = 1; i <= games; i++)
                {
                    int team1 = int.Parse(Console.ReadLine());
                    int team2 = int.Parse(Console.ReadLine());
                    if(team1 > team2) { Console.WriteLine($"Game {i} of tournament {name}: win with {team1-team2} points."); countWin++; }
                    else { Console.WriteLine($"Game {i} of tournament {name}: lost with {team2-team1} points."); countLoss++; }
                }
            }
            Console.WriteLine($"{countWin / (double)(countWin+countLoss) * 100:f2}% matches win");
            Console.WriteLine($"{countLoss / (double)(countWin+countLoss) * 100:f2}% matches lost");
        }
    }
}
