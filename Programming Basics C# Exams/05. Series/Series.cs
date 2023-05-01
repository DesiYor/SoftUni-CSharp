using System;

namespace _05.Series
{
    internal class Series
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int films = int.Parse(Console.ReadLine());
            for (int i = 0; i < films; i++)
            {
                string filmName = Console.ReadLine();
                double filmPrice = double.Parse(Console.ReadLine());
                switch (filmName)
                {
                    case "Thrones": budget -= filmPrice * (1 - 0.5);  break;
                    case "Lucifer": budget -= filmPrice * (1 - 0.4); break;
                    case "Protector": budget -= filmPrice * (1 - 0.3); break;
                    case "TotalDrama": budget -= filmPrice * (1 - 0.2); break;
                    case "Area": budget -= filmPrice * (1 - 0.1); break;
                    default: budget -= filmPrice; break; 
                }
            }
            if(budget >= 0) { Console.WriteLine($"You bought all the series and left with {budget:f2} lv."); }
            else { Console.WriteLine($"You need {Math.Abs(budget):f2} lv. more to buy the series!"); }
        }
    }
}
