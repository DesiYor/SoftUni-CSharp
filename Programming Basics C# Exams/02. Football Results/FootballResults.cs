using System;


namespace _02.Football_Results
{
    internal class FootballResults
    {
        static void Main(string[] args)
        {
            int win = 0, loss = 0, draw = 0;
            for (int i = 0; i < 3; i++)
            {
                string game  = Console.ReadLine();
                if (game[0] > game[2]) { win++; }
                else if (game[0] < game[2]) {  loss++; }    
                else { draw++; }
            }
            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {loss} games.");
            Console.WriteLine($"Drawn games: {draw}");

        }
    }
}
