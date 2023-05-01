using System;


namespace _04.Movie_Stars
{
    internal class MovieStars
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            while(true)
            {
                string name = Console.ReadLine();
                if(name == "ACTION") { Console.WriteLine($"We are left with {budget:f2} leva."); break; }
                if (name.Length > 15)
                {
                    budget -= budget * 0.20;
                    if(budget < 0) { Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors."); break; }
                }
                else
                {
                    budget -= double.Parse(Console.ReadLine());
                    if (budget < 0) { Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors."); break; }
                }
            }
        }
    }
}
