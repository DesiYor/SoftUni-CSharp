using System;


namespace _03.Movie_Destination
{
    internal class MovieDestination
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double bill = 0;

            switch (destination)
            {
                case "Dubai":
                    switch(season)
                    {
                        case "Summer": bill = (40000 * days) * (1 - 0.30); break;
                        case "Winter": bill = (45000 * days) * (1 - 0.30); break;
                        default: break;
                    }
                    break;
                case "Sofia":
                    switch (season)
                    {
                        case "Summer": bill = (12500 * days) * (1 + 0.25); break;
                        case "Winter": bill = (17000 * days) * (1 + 0.25); break;
                        default: break;
                    }
                    break;
                case "London":
                    switch (season)
                    {
                        case "Summer": bill = 20250 * days; break;
                        case "Winter": bill = 24000 * days; break;
                        default: break;
                    }
                    break;
                default: break;
            }
            if(budget >= bill)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget-bill:f2} leva left!");
            }
            else { Console.WriteLine($"The director needs {bill - budget:f2} leva more!"); }
            Console.ReadLine();
        }
    }
}
